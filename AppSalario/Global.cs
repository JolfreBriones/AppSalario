using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppSalario
{
    internal class Global
    {
        /*public static List<Empleado> Empleados = new List<Empleado>{
            new Empleado(1, "Jose", "Gonzales",Convert.ToDouble("500.00"),Convert.ToDateTime("01012000"),Convert.ToDateTime("01012000"))
            };*/
        public static List<Facultad> Facultades = new List<Facultad>
        {
            new Facultad(1,"Administración"),
            new Facultad(2,"Diseño"),
            new Facultad(3,"Comunicación"),
            new Facultad(4,"Ingeniería"),
            new Facultad(5,"Medicina"),
            new Facultad(6,"Derecho"),
            new Facultad(7,"Publicidad"),
        };

        public static List<Empleado> Empleados = new List<Empleado>
        {
            //new Empleado(1, "nombre", "apellido","DOCENTE", 10,Convert.ToDateTime( "2000-01-01"),Convert.ToDateTime( "2000-01-01"), 1),
            new Empleado(1968,"Jeronimo","Burgos","Administrativo",Convert.ToDouble("3200000"),Convert.ToDateTime("1982-04-05"),Convert.ToDateTime("1951-09-28"),1),
            new Empleado(1674,"Estefania","Villegas","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1992-03-25"),Convert.ToDateTime("1964-01-17"),1),
            new Empleado(1516,"Guillermo","Fernandez","Docente",Convert.ToDouble("4500000"),Convert.ToDateTime("1985-03-06"),Convert.ToDateTime("1963-06-26"),1),
            new Empleado(1330,"Eliana","Ramirez","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1989-02-14"),Convert.ToDateTime("1964-05-17"),1),
            new Empleado(1657,"Jose","Carmona","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1987-12-06"),Convert.ToDateTime("1963-10-10"),1),
            new Empleado(1573,"Marcela","De santis","Aux. Administrativo",Convert.ToDouble("1500000"),Convert.ToDateTime("1988-07-07"),Convert.ToDateTime("1960-05-31"),1),
            new Empleado(1658,"Daniela","Franco","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1988-06-06"),Convert.ToDateTime("1963-10-14"),1),
            new Empleado(1078,"Rafael","Cortes","Administrativo",Convert.ToDouble("4200000"),Convert.ToDateTime("1986-04-01"),Convert.ToDateTime("1962-11-21"),2),
            new Empleado(1695,"Camilo","Berrio","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1984-10-20"),Convert.ToDateTime("1960-01-05"),2),
            new Empleado(1285,"Francisco","Arias","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1984-12-27"),Convert.ToDateTime("1962-12-22"),2),
            new Empleado(1284,"Antonio","Merizalde","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1985-01-04"),Convert.ToDateTime("1962-12-11"),2),
            new Empleado(1517,"Karen","Restrepo","Aux. Administrativo",Convert.ToDouble("1500000"),Convert.ToDateTime("1985-02-26"),Convert.ToDateTime("1963-07-07"),2),
            new Empleado(1674,"David","Lemus","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1990-04-08"),Convert.ToDateTime("1962-09-12"),2),
            new Empleado(1056,"Javier","Santana","Administrativo",Convert.ToDouble("5600000"),Convert.ToDateTime("1979-10-25"),Convert.ToDateTime("1937-08-24"),3),
            new Empleado(1977,"Virginia","Saldarriaga","Docente",Convert.ToDouble("4200000"),Convert.ToDateTime("1991-09-09"),Convert.ToDateTime("1960-10-13"),3),
            new Empleado(1725,"Sergio","Posada","Docente",Convert.ToDouble("5600000"),Convert.ToDateTime("1978-02-02"),Convert.ToDateTime("1954-06-02"),3),
            new Empleado(1675,"Jorge","Zea ","Docente",Convert.ToDouble("6500000"),Convert.ToDateTime("1981-10-26"),Convert.ToDateTime("1969-09-01"),3),
            new Empleado(1968,"Mariana","Diaz ","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1993-01-01"),Convert.ToDateTime("1969-05-19"),3),
            new Empleado(1723,"Esteban","Giraldo","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1990-08-06"),Convert.ToDateTime("1965-05-10"),4),
            new Empleado(1076,"Jorge","Idarraga","Aux. Administrativo",Convert.ToDouble("1200000"),Convert.ToDateTime("1979-07-30"),Convert.ToDateTime("1940-09-08"),4),
            new Empleado(1816,"Alejandro","Simanca","Aux. Administrativo",Convert.ToDouble("1600000"),Convert.ToDateTime("1990-07-08"),Convert.ToDateTime("1969-09-01"),4),
            new Empleado(1154,"Angelina","Pulgarin","Administrativo",Convert.ToDouble("4100000"),Convert.ToDateTime("1987-07-07"),Convert.ToDateTime("1955-11-07"),4),
            new Empleado(1294,"Brenda","Aguirre","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1984-09-06"),Convert.ToDateTime("1954-09-05"),4),
            new Empleado(1428,"Gloria","Tamayo","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1986-11-12"),Convert.ToDateTime("1958-03-23"),4),
            new Empleado(1814,"Andrea","Carmona ","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1989-03-04"),Convert.ToDateTime("1969-08-17"),4),
            new Empleado(1978,"Lucero","Diaz ","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1980-06-05"),Convert.ToDateTime("1967-09-26"),4),
            new Empleado(1531,"Angela","Alzate","Técnico",Convert.ToDouble("2800000"),Convert.ToDateTime("1986-05-11"),Convert.ToDateTime("1967-01-19"),4),
            new Empleado(1931,"Felipe","Arango","Administrativo",Convert.ToDouble("2560000"),Convert.ToDateTime("1989-06-20"),Convert.ToDateTime("1969-05-28"),1),
            new Empleado(1932,"Elena","Garces","Administrativo",Convert.ToDouble("2400000"),Convert.ToDateTime("1989-06-12"),Convert.ToDateTime("1949-06-08"),1),
            new Empleado(1291,"Carmen","Uribe","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1984-12-26"),Convert.ToDateTime("1956-04-14"),1),
            new Empleado(1530,"Daniel","Ospina","Docente",Convert.ToDouble("1460000"),Convert.ToDateTime("1991-01-20"),Convert.ToDateTime("1967-01-15"),1),
            new Empleado(1152,"Alberto","Peláez","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1990-01-21"),Convert.ToDateTime("1965-10-23"),1),
            new Empleado(1079,"Elena","Perez","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1986-03-24"),Convert.ToDateTime("1962-12-02"),1),
            new Empleado(1676,"Sebastian","Carmona","Docente",Convert.ToDouble("1500000"),Convert.ToDateTime("1981-10-18"),Convert.ToDateTime("1969-09-12"),1),
            new Empleado(1290,"Oscar","Cifuentes","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1985-01-03"),Convert.ToDateTime("1966-04-03"),1),
            new Empleado(1961,"Santiago","Jaramillo","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1986-11-05"),Convert.ToDateTime("1965-04-02"),1),
            new Empleado(1675,"Luis","Melano","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1992-03-17"),Convert.ToDateTime("1964-01-28"),1),
            new Empleado(1368,"Tammy","Mendez","Docente",Convert.ToDouble("1280000"),Convert.ToDateTime("1983-03-11"),Convert.ToDateTime("1959-05-08"),1),
            new Empleado(1153,"Tomas","Ramirez","Técnico",Convert.ToDouble("1350000"),Convert.ToDateTime("1990-01-13"),Convert.ToDateTime("1965-11-03"),1),
            new Empleado(1960,"Felipe","Girando","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1986-11-13"),Convert.ToDateTime("1965-03-22"),1),
            new Empleado(1908,"Patricia","Diez","Administrativo",Convert.ToDouble("5600000"),Convert.ToDateTime("1984-05-15"),Convert.ToDateTime("1958-09-21"),1),
            new Empleado(1011,"Luisa","Sierra","Docente",Convert.ToDouble("2700000"),Convert.ToDateTime("1986-02-03"),Convert.ToDateTime("1964-11-21"),1),
            new Empleado(1359,"Sara","Vallejo","Docente",Convert.ToDouble("2300000"),Convert.ToDateTime("1990-08-09"),Convert.ToDateTime("1960-06-07"),2),
            new Empleado(1724,"Alexandra","Guerrero","Docente",Convert.ToDouble("2300000"),Convert.ToDateTime("1978-02-10"),Convert.ToDateTime("1954-05-22"),2),
            new Empleado(1923,"Lisa","Guerra","Docente",Convert.ToDouble("2300000"),Convert.ToDateTime("1986-11-27"),Convert.ToDateTime("1961-03-07"),2),
            new Empleado(1794,"Ana Maria","Rodríguez ","Docente",Convert.ToDouble("2300000"),Convert.ToDateTime("1984-12-18"),Convert.ToDateTime("1968-10-18"),2),
            new Empleado(1558,"Sofia","Marulanda","Docente",Convert.ToDouble("2300000"),Convert.ToDateTime("1982-10-16"),Convert.ToDateTime("1965-09-26"),2),
            new Empleado(1949,"Paula","Palacio","Docente",Convert.ToDouble("4100000"),Convert.ToDateTime("1981-10-12"),Convert.ToDateTime("1951-02-26"),2),
            new Empleado(1311,"Jesus","Bermudez","Docente",Convert.ToDouble("3800000"),Convert.ToDateTime("1986-09-26"),Convert.ToDateTime("1964-11-13"),2),
            new Empleado(1906,"Roberta","Toledo","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1989-09-28"),Convert.ToDateTime("1960-09-02"),2),
            new Empleado(1656,"Tatiana","Arango","Administrativo",Convert.ToDouble("2500000"),Convert.ToDateTime("1987-12-14"),Convert.ToDateTime("1963-09-29"),2),
            new Empleado(1907,"Melina","Acevedo","Administrativo",Convert.ToDouble("2600000"),Convert.ToDateTime("1989-09-20"),Convert.ToDateTime("1960-09-13"),2),
            new Empleado(1724,"Cristina","Cock","Administrativo",Convert.ToDouble("2960000"),Convert.ToDateTime("1990-07-29"),Convert.ToDateTime("1965-05-21"),2),
            new Empleado(1301,"Manuela","Casadiegos","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1984-08-06"),Convert.ToDateTime("1965-06-25"),2),
            new Empleado(1292,"Isabel","Salamanca","Administrativo",Convert.ToDouble("4350000"),Convert.ToDateTime("1987-11-20"),Convert.ToDateTime("1956-04-18"),2),
            new Empleado(1167,"Juan","Arango","Administrativo",Convert.ToDouble("5600000"),Convert.ToDateTime("1991-04-18"),Convert.ToDateTime("1970-06-27"),2),
            new Empleado(1950,"Luisa","Granda","Docente",Convert.ToDouble("4900000"),Convert.ToDateTime("1981-10-04"),Convert.ToDateTime("1951-03-09"),2),
            new Empleado(1792,"Monica","Arango ","Técnico",Convert.ToDouble("2000000"),Convert.ToDateTime("1990-12-24"),Convert.ToDateTime("1968-10-03"),2),
            new Empleado(1977,"Federico","Arroyave","Técnico",Convert.ToDouble("1300000"),Convert.ToDateTime("1980-06-13"),Convert.ToDateTime("1967-09-15"),2),
            new Empleado(1067,"Dalia","Lemos","Técnico",Convert.ToDouble("1100000"),Convert.ToDateTime("1987-09-20"),Convert.ToDateTime("1961-09-30"),2),
            new Empleado(1976,"Ana","Jaramillo","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1991-04-29"),Convert.ToDateTime("1970-10-09"),4),
            new Empleado(1168,"Maria","Lema","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1991-04-10"),Convert.ToDateTime("1970-07-08"),4),
            new Empleado(1815,"Diana","Caro","Administrativo",Convert.ToDouble("5600000"),Convert.ToDateTime("1980-02-25"),Convert.ToDateTime("1959-08-28"),4),
            new Empleado(1068,"Amalia","Vergara","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1987-09-12"),Convert.ToDateTime("1961-10-11"),4),
            new Empleado(1012,"Julian","Duque","Docente",Convert.ToDouble("2400000"),Convert.ToDateTime("1986-01-26"),Convert.ToDateTime("1964-12-02"),4),
            new Empleado(1301,"Maritza","Muñoz","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1986-01-09"),Convert.ToDateTime("1955-09-28"),4),
            new Empleado(1556,"Andrés","Peláez","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1981-11-26"),Convert.ToDateTime("1965-09-11"),4),
            new Empleado(1933,"Miguel","Sanchez","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1984-01-08"),Convert.ToDateTime("1949-06-12"),4),
            new Empleado(1333,"Carolina","Cano","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1990-04-16"),Convert.ToDateTime("1965-10-07"),4),
            new Empleado(1510,"Jessica","Marquez","Docente",Convert.ToDouble("4800000"),Convert.ToDateTime("1985-06-11"),Convert.ToDateTime("1962-11-04"),4),
            new Empleado(1574,"Samuel","Rico","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1986-02-09"),Convert.ToDateTime("1960-06-04"),4),
            new Empleado(1360,"Gustavo","Mendez","Docente",Convert.ToDouble("4000000"),Convert.ToDateTime("1988-08-01"),Convert.ToDateTime("1960-06-18"),4),
            new Empleado(1293,"Karina","Jimenez","Técnico",Convert.ToDouble("1700000"),Convert.ToDateTime("1984-09-14"),Convert.ToDateTime("1954-08-25"),4),
            new Empleado(1329,"Julieth","Osorio","Docente",Convert.ToDouble("3500000"),Convert.ToDateTime("1989-02-22"),Convert.ToDateTime("1964-05-06"),5),
            new Empleado(1572,"Lina","Villamizar","Docente",Convert.ToDouble("3600000"),Convert.ToDateTime("1988-07-15"),Convert.ToDateTime("1960-05-20"),5),
            new Empleado(1300,"Carlos","Gomez","Administrativo",Convert.ToDouble("2300000"),Convert.ToDateTime("1989-12-13"),Convert.ToDateTime("1965-09-24"),5),
            new Empleado(1557,"Simón","Gracía","Aux. Administrativo",Convert.ToDouble("1390000"),Convert.ToDateTime("1981-11-18"),Convert.ToDateTime("1965-09-22"),5),
            new Empleado(1169,"Monica","Castro","Administrativo",Convert.ToDouble("5700000"),Convert.ToDateTime("1992-10-13"),Convert.ToDateTime("1970-07-12"),5),
            new Empleado(1758,"Melisa","Uribe","Técnico",Convert.ToDouble("1900000"),Convert.ToDateTime("1982-03-18"),Convert.ToDateTime("1962-10-23"),5),
            new Empleado(1310,"Alejandra","Florez","Técnico",Convert.ToDouble("1350000"),Convert.ToDateTime("1986-10-04"),Convert.ToDateTime("1964-11-02"),5),
            new Empleado(1041,"Amalia","Gutierrez","Docente",Convert.ToDouble("4900000"),Convert.ToDateTime("1992-04-16"),Convert.ToDateTime("1965-01-25"),5),
            new Empleado(1361,"Raquel","Medina","Docente",Convert.ToDouble("2940000"),Convert.ToDateTime("1988-07-22"),Convert.ToDateTime("1960-06-22"),5),
            new Empleado(1793,"Gonzalo","Betancur","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1990-12-16"),Convert.ToDateTime("1968-10-14"),1),
            new Empleado(1967,"Santiago","Betancurt","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1991-11-09"),Convert.ToDateTime("1969-05-15"),1),
            new Empleado(1725,"Isabella","Marquez","Administrativo",Convert.ToDouble("5600000"),Convert.ToDateTime("1978-02-12"),Convert.ToDateTime("1955-05-26"),1),
            new Empleado(1969,"Karla","Molina","Aux. Técnico",Convert.ToDouble("980000"),Convert.ToDateTime("1989-04-14"),Convert.ToDateTime("1951-10-02"),1),
            new Empleado(1962,"Hilda","Rodriguez","Docente",Convert.ToDouble("2900000"),Convert.ToDateTime("1987-10-22"),Convert.ToDateTime("1945-04-06"),1),
            new Empleado(1967,"Victoria","Hincapie","Docente",Convert.ToDouble("4600000"),Convert.ToDateTime("1982-04-13"),Convert.ToDateTime("1951-09-17"),1),
            new Empleado(1426,"Pablo","Rojas ","Docente",Convert.ToDouble("5600000"),Convert.ToDateTime("1977-09-08"),Convert.ToDateTime("1968-03-09"),1),
            new Empleado(1509,"Pamela","Serna","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1985-06-19"),Convert.ToDateTime("1962-10-24"),4),
            new Empleado(1673,"Stepania","Zapata","Docente",Convert.ToDouble("1350000"),Convert.ToDateTime("1990-04-16"),Convert.ToDateTime("1962-09-01"),4),
            new Empleado(1352,"Manuel","Toro","Docente",Convert.ToDouble("1980000"),Convert.ToDateTime("1982-09-18"),Convert.ToDateTime("1958-07-22"),4),
            new Empleado(1922,"Barbara","Henao","Docente",Convert.ToDouble("2100000"),Convert.ToDateTime("1986-12-05"),Convert.ToDateTime("1961-02-24"),4),
            new Empleado(1518,"Leonardo","Vasquez","Docente",Convert.ToDouble("2600000"),Convert.ToDateTime("1990-06-18"),Convert.ToDateTime("1963-07-11"),4),
            new Empleado(1331,"Juliana","Castrillón","Docente",Convert.ToDouble("3100000"),Convert.ToDateTime("1989-05-11"),Convert.ToDateTime("1964-05-21"),4),
            new Empleado(1303,"Dinara","Lopez","Administrativo",Convert.ToDouble("5600000"),Convert.ToDateTime("1988-03-03"),Convert.ToDateTime("1955-07-10"),4),
            new Empleado(1302,"Elisa","Mota","Docente",Convert.ToDouble("3800000"),Convert.ToDateTime("1984-07-29"),Convert.ToDateTime("1955-07-06"),4),
            new Empleado(1334,"Alicia","Perez","Aux. Administrativo",Convert.ToDouble("1350000"),Convert.ToDateTime("1990-04-08"),Convert.ToDateTime("1965-10-18"),4),
            new Empleado(1975,"Carlos","Posada","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1991-05-07"),Convert.ToDateTime("1970-09-28"),6),
            new Empleado(1759,"Mauricio","Arango","Docente",Convert.ToDouble("4700000"),Convert.ToDateTime("1982-03-10"),Convert.ToDateTime("1962-11-03"),6),
            new Empleado(1055,"Adriana","Hoyos","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1991-04-08"),Convert.ToDateTime("1967-08-20"),6),
            new Empleado(1054,"Miguel","Suarez","Docente investigador",Convert.ToDouble("4100000"),Convert.ToDateTime("1991-04-16"),Convert.ToDateTime("1967-08-09"),6),
            new Empleado(1075,"Natalia","Aristizabal","Docente investigador",Convert.ToDouble("3200000"),Convert.ToDateTime("1992-08-07"),Convert.ToDateTime("1969-08-28"),6),
            new Empleado(1966,"Camila","Dominguez ","Docente investigador",Convert.ToDouble("3900000"),Convert.ToDateTime("1991-11-17"),Convert.ToDateTime("1969-05-04"),6),
            new Empleado(1354,"Susana","Ruiz","Administrativo",Convert.ToDouble("3200000"),Convert.ToDateTime("1986-05-06"),Convert.ToDateTime("1948-08-06"),6),
            new Empleado(1696,"Cathy","Higuita","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1984-10-12"),Convert.ToDateTime("1940-01-16"),6),
            new Empleado(1299,"Catalina","Osorio","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1989-12-21"),Convert.ToDateTime("1965-09-13"),6),
            new Empleado(1529,"Mariana","Gomez","Docente",Convert.ToDouble("3200000"),Convert.ToDateTime("1987-01-28"),Convert.ToDateTime("1967-01-04"),7),
            new Empleado(1080,"Jacobo","Bustos","Docente investigador",Convert.ToDouble("3700000"),Convert.ToDateTime("1988-10-29"),Convert.ToDateTime("1952-12-06"),7),
            new Empleado(1353,"Gabriel","Rodas","Docente investigador",Convert.ToDouble("3600000"),Convert.ToDateTime("1982-09-10"),Convert.ToDateTime("1958-08-02"),7),
            new Empleado(1369,"Sandra","Cano","Administrativo",Convert.ToDouble("4200000"),Convert.ToDateTime("1983-03-03"),Convert.ToDateTime("1959-05-19"),7),
            new Empleado(1370,"Evelyn","Diaz ","Docente investigador",Convert.ToDouble("3600000"),Convert.ToDateTime("1987-11-27"),Convert.ToDateTime("1959-05-23"),7),
            new Empleado(1677,"Juan","Hernandez ","Docente investigador",Convert.ToDouble("3700000"),Convert.ToDateTime("1987-11-06"),Convert.ToDateTime("1969-09-16"),7),
            new Empleado(1427,"David","Jaramillo","Docente investigador",Convert.ToDouble("3400000"),Convert.ToDateTime("1977-08-31"),Convert.ToDateTime("1958-03-19"),7),

        };

}


    internal class Estadistica
    {
        public Estadistica(int id, string titulo, string subtitulo)
        {
            Id = id;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
        }

        public int Id { get; set; }
        public string titulo { get; set; }
        public string subtitulo { get; set; }
    }


    internal class Empleado
    {
        public Empleado(int id, string nombre, string apellido, string cargo, double salario, DateTime fechaComienzo, DateTime fechaNacimiento, int facultadId)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Salario = salario;
            FechaComienzo = fechaComienzo;
            FechaNacimiento = fechaNacimiento;
            FacultadId = facultadId;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }

        public double Salario { get; set; }
        public DateTime FechaComienzo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int FacultadId { get; set; }

    }

    internal class Facultad
    {
        public Facultad(int id, string nombreFacultad)
        {
            Id = id;
            NombreFacultad = nombreFacultad;
        }

        public int Id { get; set; }
        public string NombreFacultad { get; set; }
    }
}