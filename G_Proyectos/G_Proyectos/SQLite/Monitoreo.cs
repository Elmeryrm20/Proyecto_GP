using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using G_Proyectos.Data;
using SQLite;
namespace G_Proyectos.SQLite
{
    public class Monitoreo
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int Precion { get; set; }
        public DateTime fec_registro { get; set; }

        [MaxLength(100)]
        public string nota { get; set; }





        
        public ObservableCollection<Prueba_Grafica> Data { get; set; }
        
        public Monitoreo()
        {

            Data = new ObservableCollection<Prueba_Grafica>();
            FillData();

        }



        private void FillData()
        {
            Prueba_Grafica obj = new Prueba_Grafica()
            {
                Name = "Primero",
                Quantity = 15
            };

            Data.Add(obj);

            Prueba_Grafica obj2 = new Prueba_Grafica()
            {
                Name = "Segundo",
                Quantity = 8
            };

            Data.Add(obj2);

            Prueba_Grafica obj3 = new Prueba_Grafica()
            {
                Name = "Tercero",
                Quantity = 18
            };

            Data.Add(obj3);
        }
    }
}
