// Create new class: Reports/ReportDatasets.cs
using System.Data;

namespace MidDb26_25GA49
{
    public class ReportDatasets
    {
        public DataTable GetProjectsWithAdvisors()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = @"
                SELECT 
                    p.Id as ProjectId,
                    p.Title as ProjectTitle,
                    p.Description as ProjectDescription,
                    gp.GroupId,
                    g.GroupName,
                    GROUP_CONCAT(DISTINCT CONCAT(per.FirstName, ' ', per.LastName) SEPARATOR ', ') as StudentNames,
                    GROUP_CONCAT(DISTINCT s.RegistrationNo SEPARATOR ', ') as RegistrationNumbers,
                    pa.AdvisorId,
                    CONCAT(apers.FirstName, ' ', apers.LastName) as AdvisorName,
                    l.Value as AdvisorRole,
                    pa.AssignmentDate
                FROM project p
                LEFT JOIN groupproject gp ON p.Id = gp.ProjectId
                LEFT JOIN `group` g ON gp.GroupId = g.Id
                LEFT JOIN groupstudent gs ON g.Id = gs.GroupId AND gs.Status = 3
                LEFT JOIN student s ON gs.StudentId = s.Id
                LEFT JOIN person per ON s.Id = per.Id
                LEFT JOIN projectadvisor pa ON p.Id = pa.ProjectId
                LEFT JOIN advisor a ON pa.AdvisorId = a.Id
                LEFT JOIN person apers ON a.Id = apers.Id
                LEFT JOIN lookup l ON pa.AdvisorRole = l.Id
                GROUP BY p.Id, p.Title, p.Description, gp.GroupId, g.GroupName, 
                         pa.AdvisorId, apers.FirstName, apers.LastName, l.Value, pa.AssignmentDate
                ORDER BY p.Title";

            return db.ExecuteQuery(query);
        }

        public DataTable GetMarksheet()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = @"
                SELECT 
                    g.Id as GroupId,
                    g.GroupName,
                    p.Title as ProjectTitle,
                    CONCAT(per.FirstName, ' ', per.LastName) as StudentName,
                    s.RegistrationNo,
                    e.Name as EvaluationName,
                    e.TotalMarks,
                    e.TotalWeightage,
                    COALESCE(ge.ObtainedMarks, 0) as ObtainedMarks,
                    ge.EvaluationDate,
                    (COALESCE(ge.ObtainedMarks, 0) * e.TotalWeightage / 100.0) as WeightedScore
                FROM `group` g
                JOIN groupstudent gs ON g.Id = gs.GroupId AND gs.Status = 3
                JOIN student s ON gs.StudentId = s.Id
                JOIN person per ON s.Id = per.Id
                LEFT JOIN groupproject gp ON g.Id = gp.GroupId
                LEFT JOIN project p ON gp.ProjectId = p.Id
                CROSS JOIN evaluation e
                LEFT JOIN groupevaluation ge ON g.Id = ge.GroupId AND e.Id = ge.EvaluationId
                ORDER BY g.GroupName, s.RegistrationNo, e.Id";

            return db.ExecuteQuery(query);
        }

        public DataTable GetGroupsSummary()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = @"
                SELECT 
                    g.Id as GroupId,
                    g.GroupName,
                    g.Created_On,
                    l.Value as Status,
                    COUNT(DISTINCT gs.StudentId) as TotalMembers,
                    COUNT(DISTINCT gp.ProjectId) as HasProject,
                    GROUP_CONCAT(DISTINCT CONCAT(p.FirstName, ' ', p.LastName) SEPARATOR ', ') as Members
                FROM `group` g
                LEFT JOIN lookup l ON g.IsActive = l.Id
                LEFT JOIN groupstudent gs ON g.Id = gs.GroupId AND gs.Status = 3
                LEFT JOIN student s ON gs.StudentId = s.Id
                LEFT JOIN person p ON s.Id = p.Id
                LEFT JOIN groupproject gp ON g.Id = gp.GroupId
                GROUP BY g.Id, g.GroupName, g.Created_On, l.Value
                ORDER BY g.GroupName";

            return db.ExecuteQuery(query);
        }
    }
}