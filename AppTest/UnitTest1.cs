using System;
using Xunit;
using AppLibreria;

namespace AppTest
{
    public class UnitTest1
    {

        
        [Theory]
        [InlineData(true,true,true,true)]
        [InlineData(false,true,true,true)]
        [InlineData(false,false,false,true)]
        [InlineData(false,false,true,false)]
        public void AplicamosPcr_Equal(bool sintomas, bool inmuno, bool vacuna, bool esperado)
        {
            //preparamos
            var urg =new Triaje();
            //Invocamos
            var resultado = urg.AplicamosPcr(sintomas,vacuna, inmuno);
            //Asertamos
            Assert.Equal(esperado,resultado);
        }
    }
}
