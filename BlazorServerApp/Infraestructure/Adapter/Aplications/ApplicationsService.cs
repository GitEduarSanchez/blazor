using Domain.Entity;
using Domain.Ports;

namespace Infraestructure.Adapter.Aplications;

public class ApplicationsService(HttpClient _httpClient) : IApplicationService
{
    async Task<ApplicationsEntity> IApplicationService.GetAplicacionesAsync()
    {
        //var response = await _httpClient.GetAsync("https://seuslab.sura.com/auth/applications");

        var aplicaciones = new ApplicationsEntity
        {
            Categories =
                [
                    new CategoryEntity
                    {
                        Name = "Herramientas de Trabajo",
                        Applications =
                        [
                            new()
                            {
                                Description = "GestorProcesosSURAWeb",
                                Icon = "GestorProcesosLocal",
                                Name = "Gestor de procesos",
                                Url = new Uri("https://appsseglab.suranet.com/GestorProcesosSURAWeb/")
                            },
                            new()
                            {
                                Description = "Administrador de parámetros",
                                Icon = "parametrosapp",
                                Name = "Administrador de parametros",
                                Subcategory = "Módulos",
                                Url = new Uri("https://parametrosapp.labsura.com/parametros")
                            },
                            new()
                            {
                                Description = "Aplicativo de aprovisionamiento de usuarios y aplicaciones",
                                Icon = "APUS",
                                Name = "Aprovisionamiento",
                                Url = new Uri("https://appsseglab.suranet.com/aprovisionamiento/InicioServlet")
                            }
                        ]
                    },
                    new()
                    {
                        Name = "Servicios para Empleados",
                        Applications =
                        [
                            new()
                            {
                                Description = "Aplicación para gestión de claves y usuarios de Seguros Voluntarios y Obligatorios",
                                Icon = "AdministradorPortales",
                                Name = "Administrador Portales",
                                Url = new Uri("https://adminportaleslabo.suramericana.com")
                            }
                        ]
                    },
                    new ()
                    {
                        Name = "Tecnológicos",
                        Applications =
                        [
                            new()
                            {
                                Description = "Service provider de la aplicacion de administracionsss",
                                Icon = "seus-consola",
                                Name = "SEUS 4",
                                Url = new Uri("https://seusconsola.labsura.com")
                            },
                            new()
                            {
                                Description = "Aplicacion Asegura tu app",
                                Icon = "Aseguratuapp",
                                Name = "AseguraTuAPP",
                                Url = new Uri("https://aseguratuapplab.suranet.com")
                            },
                            new()
                            {
                                Description = "STOnline OCI LAB",
                                Icon = "SrvStonlineOCI",
                                Name = "STOnline",
                                Url = new Uri("https://stonline.labsura.com/stonline/")
                            },
                            new()
                            {
                                Description = "Listas maestras",
                                Icon = "adminlistasmaestras",
                                Name = "Listas Maestras",
                                Url = new Uri("https://listasmaestrasapp.labsura.com/")
                            }
                        ]
                    },
                    new()
                    {
                        Name = "Información para la Gestión",
                        Applications =
                        [
                            new()
                            {
                                Description = "Sistema para la atención de reclamaciones de Suramericana.",
                                Icon = "ATRSura",
                                Name = "ATR Sura",
                                Url = new Uri("https://appsseglab.suranet.com/ATRSura")
                            },
                             new()
                            {
                                Description = "Certificación de Usuarios",
                                Icon = "adminbots",
                                Name = "Certificación de Usuarios",
                                Subcategory = "Módulos",
                                Url = new Uri("https://adminbots.labsura.com")
                            }
                        ]
                    }
                ]
         };
        return await Task.FromResult(aplicaciones);
    }
}