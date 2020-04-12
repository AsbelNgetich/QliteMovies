namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'0621b0b8-9613-47f7-8c54-0d329019c1fa', N'Admin@movieRental.com', 0, N'AKAzoDH+zesBDDfOobuiHMZgdN2tYQOtA9F7q6mMBJd0BAivJhcf3LssuC+oy2SVvw==', N'08e056e4-4029-435f-ae7e-47c6e471917e', NULL, 0, 0, NULL, 1, 0, N'Admin@movieRental.com')
                  INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'aa32ab08-7610-41b7-a62c-ee1fbd448f27', N'guest@movieRental.com', 0, N'AJJXX8sfvYsdUVn4BNe3iGoVzfhdQl/FETSj3t7x+F+0o6oIWjffbd2/7h5jAEKpQA==', N'03537703-c0da-4823-8528-2969134fa105', NULL, 0, 0, NULL, 1, 0, N'guest@movieRental.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c57c5615-a6e9-4bfb-9088-128267db6be4', N'CanManageMovie')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0621b0b8-9613-47f7-8c54-0d329019c1fa', N'c57c5615-a6e9-4bfb-9088-128267db6be4')
                
               ");
        }
        
        public override void Down()
        {
        }
    }
}
