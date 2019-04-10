namespace Vidly2020.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'dcd00ad5-4c90-4b0f-affa-2e94c22e1fb3', N'admin@vidly.com', 0, N'ACSfYd8v3AYtO3spriIxIFEvGfhapLFBZs1v2VnCVMJlnIutsJcY1LDayjBoaIEybg==', N'f24f8e57-854d-4517-b821-d04355c503f4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'1f0cc9f8-df70-4e63-9425-93b041a9d691', N'guest@vidly.com', 0, N'AEIO71NPU5eYIDOqnXuOYTI0bRcGrMVvsuRNebbRYf5FKejOF0V5SvknM8LkWO/jXw==', N'9c75a79f-786e-4ece-91f8-07e8f5997230', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3788d095-4822-474e-ac7a-1c11501e1c44', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dcd00ad5-4c90-4b0f-affa-2e94c22e1fb3', N'3788d095-4822-474e-ac7a-1c11501e1c44')


");
        }

    public override void Down()
        {
        }
    }
}
