using AutoMapper;
using System.Linq;
using System.Reflection;


namespace Campeonato.Infra.Data.Mapper
{
    public static class MappingConfig
    {

        public static void RegisterMap()
        {
            var targetAssembly = Assembly.GetExecutingAssembly();

            var automapperProfiles = targetAssembly.GetTypes()
                .Where(type => type.IsSubclassOf(typeof(Profile)));
            
            AutoMapper.Mapper.Initialize(cfg =>
            {
                foreach (var automapperProfile in automapperProfiles)
                {
                    cfg.AddProfile(automapperProfile);
                }
            });


        }


    }
}
