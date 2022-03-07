using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class RubroData
    {
        public class Rubro
        {
            public string rubroid { get; set; }
            public string rubroCategoria { get; set; }
            public string imagen { get; set; }
            public string description { get; set; }
            public double porcentaje { get; set; }
        }

        public static List<Rubro> GetRubros()
        {
            List<Rubro> rubros = new List<Rubro>();

            // Programas TV
            Rubro r1 = new Rubro();
            r1.rubroid = "ProgramasTV";
            r1.rubroCategoria = "The Simpsons";
            r1.imagen = @"\Imagenes\The Simpsons.JPG";
            r1.description = "The Simpsons es una serie de animación para adultos de comedia satírica emitida por primera vez en el 1989. Todos la hemos visto alguna vez y todos sabemos bien de qué trata. Podemos decir es que la influencia y popularidad que ha tenido esta serie es ampliamente superior a cualquier otra serie del mundo. La influencia que tuvo el éxito de esta serie llevó a la creación de otras series como Padre de familia o Futurama. El 40.39% de los entrevistados dijo haber visto el programa alguna vez.";
            r1.porcentaje = 0.4039;
            rubros.Add(r1);

            Rubro r2 = new Rubro();
            r2.rubroid = "ProgramasTV";
            r2.rubroCategoria = "Friends";
            r2.imagen = @"\Imagenes\Friends.JPG";
            r2.description = "Friends es una serie de comedia emitida por primera vez en septiembre del 1994, y por última vez en mayo de 2004, con un total de 236 episodios durante las 10 temporadas de emisión. Durante sus 10 temporadas en activo tuvo más de 200 millones de espectadores activos en todo el mundo, y esta cifra no ha hecho más que incrementarse desde que terminó, y es que sigue siendo una de las series más vistas en la actualidad. El 25.14% de los entrevistados dijo haber visto el programa alguna vez.";
            r2.porcentaje = 0.2514;
            rubros.Add(r2);

            Rubro r3 = new Rubro();
            r3.rubroid = "ProgramasTV";
            r3.rubroCategoria = "Game of Thrones";
            r3.imagen = @"\Imagenes\GoT.JPG";
            r3.description = "Game of Thrones es una serie de drama y fantasía medieval que fue emitida por primera vez en abril del 2011, y su última emisión fue en mayo de 2019, con récord absoluto de espectadores. Durante prácticamente la totalidad de estos 8 años ha sido la serie más vista. Al comienzo la serie ganó mucha popularidad por ser una serie de gran calidad. Actualmente es considerada una de las mejores series de la historia. El 20.19% de los entrevistados dijo haber visto el programa alguna vez.";
            r3.porcentaje = 0.2019;
            rubros.Add(r3); 

            Rubro r4 = new Rubro();
            r4.rubroid = "ProgramasTV";
            r4.rubroCategoria = "Ninguno";
            r4.imagen = "";
            r4.description = "Test 3";
            r4.porcentaje = 0.1428;
            rubros.Add(r4);

            // Libros
            Rubro r5 = new Rubro();
            r5.rubroid = "Libros";
            r5.rubroCategoria = "La Biblia";
            r5.imagen = @"\Imagenes\Biblia.jpg";
            r5.description = "Es el libro más vendido, a mucha distancia del siguiente (5000 millones de copias). ¡Y sigue encabezando la lista de libros más vendidos cada año! Ha sido traducida parcialmente a 2454 idiomas e íntegramente a 438. La edición original está escrita en hebreo, arameo y griego. En sus diferentes ediciones e idiomas se estima que el texto sagrado del cristianismo se ha impreso entre 2.500 y 6.000 millones de veces. El 50.52% de los entrevistados dijo haber leído este libro alguna vez.";
            r5.porcentaje = 0.5052;
            rubros.Add(r5);

            Rubro r6 = new Rubro();
            r6.rubroid = "Libros";
            r6.rubroCategoria = "Don Quijote de la Mancha";
            r6.imagen = @"\Imagenes\Don Quijote.png";
            r6.description = "Don Quijote de la Mancha (1605 y 1615). El segundo libro más vendido de la Historia en general. La famosa novela de Miguel de Cervantes es, probablemente, el texto de ficción más vendido de la historia. Se ha discutido largo y tendido sobre la cantidad de copias que se han impreso de Don Quijote, pero es seguro que supera con creces los 200 millones y podría rondar los 400. El 20.23% de los entrevistados dijo haber leído este libro alguna vez.";
            r6.porcentaje = 0.2023;
            rubros.Add(r6);

            Rubro r7 = new Rubro();
            r7.rubroid = "Libros";
            r7.rubroCategoria = "La Odisea";
            r7.imagen = @"\Imagenes\Odisea.png";
            r7.description = "Más de 250 traducciones, 902 ediciones y un total de 145 millones hacen a la Odisea merecedora de estar en este ránking. Junto con la Ilíada, esta obra constituye una de las piedras angulares de la cultura occidental. El relato que hace Homero de las aventuras de Odiseo en su camino de regreso desde Troya hasta su patria, Ítaca, ha sido desde siempre una mina inagotable de motivos e imágenes para escritores y artistas. El 17.77% de los entrevistados dijo haber leído este libro alguna vez.";
            r7.porcentaje = 0.1777;
            rubros.Add(r7);

            Rubro r8 = new Rubro();
            r8.rubroid = "Libros";
            r8.rubroCategoria = "Ninguno";
            r8.imagen = "";
            r8.description = "Test 3";
            r8.porcentaje = 0.1148;
            rubros.Add(r8);

            // Lenguages de Programación
            Rubro r9 = new Rubro();
            r9.rubroid = "LenguajesProg";
            r9.rubroCategoria = "Python";
            r9.imagen = @"\Imagenes\Python.JPG";
            r9.description = "El lenguaje de programación Python es el preferido a nivel internacional, según el PopularitY of Programming Language Index (acortado como PYPL y traducido al español como Índice de Popularidad de Lenguajes de Programación). Así, en enero de 2019 este era utilizado por casi el 28.27% de los programadores web, tal y como se estima en un análisis de las búsquedas en Google de tutoriales sobre programación.";
            r9.porcentaje = 0.2827;
            rubros.Add(r9);

            Rubro r10 = new Rubro();
            r10.rubroid = "LenguajesProg";
            r10.rubroCategoria = "Java";
            r10.imagen = @"\Imagenes\Java.JPG";
            r10.description = "El Índice de popularidad de lenguajes de programación PYPL se crea analizando la frecuencia con la que se buscan tutoriales de idiomas en Google. Cuanto más se busca un tutorial de lenguaje, más popular se supone que es el lenguaje. Es un indicador líder. Los datos sin procesar provienen de Google Trends. De acuerdo a dicho índice, en marzo de 2022, el 18.03% de los programadores utilizan Java.";
            r10.porcentaje = 0.1803;
            rubros.Add(r10);

            Rubro r11 = new Rubro();
            r11.rubroid = "LenguajesProg";
            r11.rubroCategoria = "JavaScript";
            r11.imagen = @"\Imagenes\JS.JPG";
            r11.description = "Según la encuesta anual realizada por Stack Overflow cerca del 70% declararon usar JavaScript. En EE. UU. 16 de las 25 compañías unicornio (las principales startups privadas valoradas cerca a más de 1 mil millones) mencionan que usan Javascript en sus proyectos. Según el Índice de Popularidad de Lenguajes de Programación (PYPL por sus singlas en inglés) el 8.86% de los programadores utiliza JavaScript.";
            r11.porcentaje = 0.0886;
            rubros.Add(r11);

            Rubro r12 = new Rubro();
            r12.rubroid = "LenguajesProg";
            r12.rubroCategoria = "Otros";
            r12.imagen = "";
            r12.description = "";
            r12.porcentaje = 0.4484;
            rubros.Add(r12);

            return rubros;
        }
    }
}
