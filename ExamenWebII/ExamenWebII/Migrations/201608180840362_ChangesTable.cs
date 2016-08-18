namespace ExamenWebII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Inventarios", name: "Producto_Id", newName: "Productos_Id");
            RenameIndex(table: "dbo.Inventarios", name: "IX_Producto_Id", newName: "IX_Productos_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Inventarios", name: "IX_Productos_Id", newName: "IX_Producto_Id");
            RenameColumn(table: "dbo.Inventarios", name: "Productos_Id", newName: "Producto_Id");
        }
    }
}
