// <auto-generated />
namespace OnionArch.Infrastructure.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class CompayIdToCompanyId : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(CompayIdToCompanyId));
        
        string IMigrationMetadata.Id
        {
            get { return "201701230652341_CompayIdToCompanyId"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}