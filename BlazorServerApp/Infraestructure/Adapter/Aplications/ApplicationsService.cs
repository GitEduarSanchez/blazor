using Domain.Entity;
using Domain.Ports;

namespace Infraestructure.Adapter.Aplications;

public class ApplicationsService(HttpClient _httpClient) : IApplicationRepository
{
    public async Task<ApplicationsEntity> GetAplicacionesRepositoryAsync()
    {
        var mock = new ApplicationsEntity
        {
            Categories =
            [
                new CategoryEntity
                {
                    Name = "Gestión de Clientes",
                    Applications =
                    [
                        new ApplicationEntity
                        {
                            Description = "Servicios Sarlaft",
                            Icon = "Sarlaft",
                            Name = "Sarlaft",
                            Url = new Uri("https://appssegdllo02.suranet.com/Sarlaft/com.sura.sarlaft.pubs.SerSarlaft")
                        },
                        new ApplicationEntity
                        {
                            Description = "autogestion-clientes",
                            Icon = "autogestion-clientes",
                            Name = "autogestion-clientes",
                            Url = new Uri("http://srdkrd01.suramericana.com.co:9980/autogestionclientes/")
                        },
                        new ApplicationEntity
                        {
                            Description = "autogestionclientes",
                            Icon = "autogestionclientes",
                            Name = "autogestionclientes",
                            Url = new Uri("http://localhost.suramericana.com.co:4200")
                        },
                        new ApplicationEntity
                        {
                            Description = "Aplicación Gestión de Relación con Cliente - Para consulta y actualización de clientes",
                            Icon = "Sic",
                            Name = "Gestión de Relación con el Cliente",
                            Url = new Uri("http://localhost.suranet.com:7001/sic")
                        },
                        new ApplicationEntity
                        {
                            Description = "Fatca",
                            Icon = "Fatca",
                            Name = "Fatca",
                            Url = new Uri("https://appssegdllo02.suranet.com/Sarlaft/com.sura.sarlaft.pubs.SerFatca")
                        },
                        new ApplicationEntity
                        {
                            Description = "SicSalud",
                            Icon = "SicSalud",
                            Name = "SicSalud",
                            Url = new Uri("http://segdllo02.suranet.com/sic/servlet/suramericana.sic.generico.LogonXML?servicio=Sic")
                        },
                        new ApplicationEntity
                        {
                            Description = "Servicio PUBS para consultar plantillas.",
                            Icon = "serSicCombinadorPlantillas",
                            Name = "Gestión de Relación con el Cliente Combinador Plantillas",
                            Url = new Uri("https://segdllo02.suranet.com/sic/servlet/suramericana.sic.pubs.CtrlCombinadorPlantillas")
                        },
                        new ApplicationEntity
                        {
                            Description = "Servicio PUBS serSicCausasInvdez expuesto por Sic (Suracliente,Gestión Causas Invalidez ).",
                            Icon = "serSicCausasInvdez",
                            Name = "Gestión Causas Invalidez",
                            Url = new Uri("https://segdllo02.suranet.com/sic/servlet/suramericana.sic.pubs.CtrlCausasInvdez")
                        },
                        new ApplicationEntity
                        {
                            Description = "Servicio PUBS para consultar datos de sura cliente.",
                            Icon = "serTodoSuracliente1",
                            Name = "Todo Sura Cliente",
                            Url = new Uri("https://segdllo02.suranet.com/sic/servlet/suramericana.sic.pubs.CtrlSuracliente")
                        },
                        new ApplicationEntity
                        {
                            Description = "Aplicación Sarlaft 4.0 Admin",
                            Icon = "Sarlaft4Admin",
                            Name = "SARLAFT 4.0",
                            Url = new Uri("https://sarlaft.dllosura.com/")
                        },
                        new ApplicationEntity
                        {
                            Description = "Consultas y Reportes ARL",
                            Icon = "consultasreportesarlgeneral-local",
                            Name = "MIRA",
                            Url = new Uri("http://local.arlsura.com:3000/consultasreportesarlgeneral/index.html")
                        },
                        new ApplicationEntity
                        {
                            Description = "Consultas y Reportes ARL",
                            Icon = "consultasreportesarlgeneral",
                            Name = "MIRA",
                            Url = new Uri("https://afiliacionesdllo.arlsura.com/consultasreportesarlgeneral/index.html")
                        }
                    ]
        },
                new CategoryEntity
                {
                    Name = "Generación del Conocimiento",
                    Applications =
                    [
                        new ApplicationEntity
                        {
                            Description = "Ingreso a aplicativo de la biblioteca como administrador",
                            Icon = "bibliotecaAdm",
                            Name = "bibliotecaAdm",
                            Url = new Uri("http://segdllo01.suranet.com/bibliotecaAdmin/")
                        },
                        new ApplicationEntity
                        {
                            Description = "CarterasColectivas_FondoAhorro",
                            Icon = "CarterasColectivas_FondoAhorro",
                            Name = "CarterasColectivas_FondoAhorro",
                            Url = new Uri("http://mdeapsfrlx01.suranet.com/forms/frmservlet?config=FI")
                        },
                        new ApplicationEntity
                        {
                            Description = "serSiaServProveedores",
                            Icon = "serSiaServProveedores",
                            Name = "serSiaServProveedores",
                            Url = new Uri("http://segdllo02.suranet.com/ServiciosAutosura/LogonSIAServlet?servicio=serSiaServProveedores")
                        },
                        new ApplicationEntity
                        {
                            Description = "serSiaServRegistrado",
                            Icon = "serSiaServRegistrado",
                            Name = "serSiaServRegistrado",
                            Url = new Uri("http://segdllo02.suranet.com/ServiciosAutosura/LogonSIAServlet?servicio=serSiaServRegistrado")
                        }
                    ]
                },
                new CategoryEntity
            {
                Name = "Tecnológicos",
                Applications =
                [
                    new ApplicationEntity
                    {
                        Description = "Guidewire Policy Center",
                        Icon = "PolicyCenter",
                        Name = "Policy Center",
                        Url = new Uri("http://dllocoreseguros.suramericana.com.co/pc")
                    },
                    new ApplicationEntity
                    {
                        Description = "Nuevo Core Seguros BillingCenter - Dllo WLS",
                        Icon = "BillingCenter",
                        Name = "Billing Center",
                        Url = new Uri("http://dllocoreseguros.suramericana.com:7004/bc")
                    },
                    new ApplicationEntity
                    {
                        Description = "Holmes, aplicación de configuración de LOGs de aplicaciones",
                        Icon = "Holmes",
                        Name = "Holmes",
                        Subcategory = "Módulos",
                        Url = new Uri("http://lnfdllod01.suranet.com/holmes")
                    },
                    new ApplicationEntity
                    {
                        Description = "Ingreso Aplicación Navigator",
                        Icon = "SrvIngresoP8",
                        Name = "SrvIngresoP8",
                        Subcategory = "Archivo Digital",
                        Url = new Uri("http://p8appdll.suranet.com/P8LoginWeb/")
                    },
                    new ApplicationEntity
                    {
                        Description = "administrador de afiliación en linea y gestión comercial",
                        Icon = "afilinea-admin",
                        Name = "Afiliación en Linea - Administrador",
                        Url = new Uri("http://localhost.suranet.com:9000/index.html#")
                    },
                    new ApplicationEntity
                    {
                        Description = "Gestión ingresos interno",
                        Icon = "pruebaconcepto-gestioningresosarl",
                        Name = "Afiliación en Linea - Administrador",
                        Url = new Uri("http://localhost.suranet.com:7210")
                    },
                    new ApplicationEntity
                    {
                        Description = "Gestión ingresos interno",
                        Icon = "gestioningresosarl",
                        Name = "Gestión Ingresos ARL",
                        Url = new Uri("http://segobl.dllosura.com/gestioningresos")
                    },
                    new ApplicationEntity
                    {
                        Description = "borrar sp",
                        Icon = "DiagnosicoBackEndBorrar",
                        Name = "borrar sp",
                        Url = new Uri("http://modulodiagnosticosdllo.suramericana.com/modulodiagnosticos/")
                    },
                    new ApplicationEntity
                    {
                        Description = "Gestión Ingresos ARL Local",
                        Icon = "gestioningresosarl-local",
                        Name = "Gestión Ingresos ARL Local",
                        Url = new Uri("http://localhost.suranet.com:9490/gestioningresos")
                    }
                ]
            },
                new CategoryEntity
        {
            Name = "Servicios para Empleados",
            Applications =
            [
                new ApplicationEntity
                {
                    Description = "Aplicación para gestión de claves y usuarios de Seguros Voluntarios y Obligatorios",
                    Icon = "AdministradorPortales",
                    Name = "Administrador Portales",
                    Url = new Uri("http://adminportalesdllo.suramericana.com")
                },
                new ApplicationEntity
                {
                    Description = "Mi cuenta sura",
                    Icon = "mi-cuenta-sura",
                    Name = "Mi Cuenta SURA",
                    Url = new Uri("https://micuentadllo.suranet.com")
                }
            ]
        },
                new CategoryEntity
        {
            Name = "Herramientas de Trabajo",
            Applications =
            [
                new ApplicationEntity
                {
                    Description = "Aplicación SOAT",
                    Icon = "Soat",
                    Name = "SOAT",
                    Url = new Uri("http://segdllo02.suranet.com/soat")
                },
                new ApplicationEntity
                {
                    Description = "Consultas y Reportes ARL",
                    Icon = "consultasreportesarlgeneral",
                    Name = "MIRA",
                    Url = new Uri("https://afiliacionesdllo.arlsura.com/consultasreportesarlgeneral/index.html")
                }

            ]
        },
                new CategoryEntity
            {
                Name = "Información para la Gestión",
                Applications = new List<ApplicationEntity>
                {
                    new ApplicationEntity
                    {
                        Description = "ClaimCenter Dllo",
                        Icon = "ClaimCenter",
                        Name = "Claim Center",
                        Url = new Uri("http://dllocoreseguros.suramericana.com:7005/cc")
                    }

                }
            }
          ]
        };
        SetDefaultSubcategory(mock);
        return mock;
    }

    private void SetDefaultSubcategory(ApplicationsEntity applicationsEntity)
    {
        foreach (var category in applicationsEntity.Categories)
        {
            foreach (var application in category.Applications)
            {
                if (string.IsNullOrEmpty(application.Subcategory))
                {
                    application.Subcategory = " Pagina Principal";
                }
            }
        }
    }
}