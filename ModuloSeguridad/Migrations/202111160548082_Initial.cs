namespace ModuloSeguridad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Institucions",
                c => new
                    {
                        codigo = c.Int(nullable: false, identity: true),
                        cuit = c.Long(nullable: false),
                        razonSocial = c.String(),
                        domicilio = c.String(),
                        telefono = c.String(),
                        email = c.String(),
                        nomFantasia = c.String(),
                        rubro = c.String(),
                        actividadPrincipal = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.codigo);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        idPersona = c.Int(nullable: false, identity: true),
                        documento = c.Long(nullable: false),
                        apellidos = c.String(),
                        nombres = c.String(),
                        fechaNacimiento = c.DateTime(nullable: false),
                        genero = c.String(),
                        domicilio = c.String(),
                        telefono = c.String(),
                        celular = c.String(),
                        redes = c.String(),
                        area = c.String(),
                        cargo = c.String(),
                        legajo = c.Int(),
                        fechaIngreso = c.DateTime(),
                        cargo1 = c.String(),
                        area1 = c.String(),
                        estado = c.String(),
                        fechaAlta = c.DateTime(),
                        estado1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        empresa_codigo = c.Int(),
                        empresa_codigo1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPersona)
                .ForeignKey("dbo.Institucions", t => t.empresa_codigo)
                .ForeignKey("dbo.Institucions", t => t.empresa_codigo1, cascadeDelete: true)
                .Index(t => t.empresa_codigo)
                .Index(t => t.empresa_codigo1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personas", "empresa_codigo1", "dbo.Institucions");
            DropForeignKey("dbo.Personas", "empresa_codigo", "dbo.Institucions");
            DropIndex("dbo.Personas", new[] { "empresa_codigo1" });
            DropIndex("dbo.Personas", new[] { "empresa_codigo" });
            DropTable("dbo.Personas");
            DropTable("dbo.Institucions");
        }
    }
}
