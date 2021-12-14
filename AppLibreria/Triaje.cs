using System;

namespace AppLibreria
{
    public class Triaje
     {
       
            

            public bool AplicamosPcr( bool sintomas, bool vacuna, bool inmuno){
                 if(sintomas){
                
                 return true;
             }
             if( !vacuna){
                
                 return true;
             }
             if(inmuno){
                 
                 return true;
             }
             if(vacuna){
               
                 return false;
             }



                return true;
            }
         }

}
