namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'45d47d3e-6feb-43a1-a9ad-8bbdd75b39e5', N'asdf@gmail.com', 0, N'AJguxdOzHiHv5RUa6CYCYmc7masU9TeGSWLY0GHM4h4gMVmC90mqNcxlZ6gnv3GA2Q==', N'a4df23fd-3350-4f60-a8ce-822aedb47e5d', NULL, 0, 0, NULL, 1, 0, N'asdf@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dc3ce98d-5a17-473b-83fb-eaed4c221df2', N'hesnaakay@gmail.com', 0, N'AF1xLiuzxpCjebufhxrlms8H3YQnOXfgUJj2v6NUxEP5usM+HmxwLSop+HtBygdgIQ==', N'6df99fa7-879c-43f1-978d-d62d35a66448', NULL, 0, 0, NULL, 1, 0, N'hesnaakay@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'23e4243f-fcdb-4d2e-98a9-51b8489e628c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dc3ce98d-5a17-473b-83fb-eaed4c221df2', N'23e4243f-fcdb-4d2e-98a9-51b8489e628c')

");
        }
        
        public override void Down()
        {
            
        }
    }
}
