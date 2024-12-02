using Microsoft.AspNetCore.Authorization;

namespace AuthECAPI.Controllers
{
    public static class AuthorizationDemoEndpoints
    {
        public static IEndpointRouteBuilder MapAuthorizationDemoEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/AdminOrLecturerOrDirectorOrFounder", [Authorize(Roles = "Admin,Lecturer,Director,Founder")] ()=>
            { return "Admin Or Lecturer Or Director Or Founder"; });

            app.MapGet("/UTstudentsOnly", [Authorize(Policy = "HasUTnumber")] () =>
            { return "UT Students Only"; });

            app.MapGet("/studentOnly", [Authorize(Roles = "Student",Policy ="StudentOnly")] () =>
            { return "Apply for Leave."; });

            return app;
        }

        [Authorize(Roles ="Admin")]
        private static string AdminOnly()
        {
            return "Admin Only";
        }
    }
}
