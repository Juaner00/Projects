using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPIND{

    class DepInd{
    
        static void Main(string[] args){
        
            Console.WriteLine("Ingrese el salario mensual, escriba D si es dependiente o escriba I si es independiente");
            double sm = double.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            double st = sm;
            double bc = sm * 0.4;
            double p = 0;
            double eps = 0;
            double sa = 12 * sm;
            double sr = 0;
            
            if (d == "D"){
            
                //Deducciones
                p = 0.04;
                st -= p * bc;

                eps = 0.04;
                st -= eps * bc;

                Console.WriteLine("Su pension es " + p * bc);
                Console.WriteLine("Su eps es " + eps * bc);

                //Bonificaciones
                double prima = sm;
                sa += prima;

                sr = st;

                Console.WriteLine("Su salario anual es " +sa);
                Console.WriteLine("Su salario real mensual es " + sr);

            }else if (d == "I"){
            
                Console.WriteLine("Seleccione el riesgo de 1-5. Financieras, trabajos de oficina, administrativos, centros educativos, restaurantes.");
                Console.WriteLine("1 Financieras, trabajos de oficina, administrativos, centros educativos, restaurantes. \n 2 Algunos procesos manufactureros como fabricación de tapetes, tejidos, confecciones y flores artificiales, almacén por departamentos, algunas labores agrícolas.\n 3 Algunos procesos manufactureros como la fabricación de agujas, alcoholes y artículos de cuero.\n 4 Procesos manufactureros como fabricación de aceites, cervezas, vidrios, procesos de galvanización, transportes y servicios de vigilancia privada.\n 5 Areneras, manejo de asbesto, bomberos, manejo de explosivos, construcción y explotación petrolera.");
                int r = int.Parse(Console.ReadLine());
                double uno = 0.00522;
                double dos = 0.01044;
                double tres = 0.02436;
                double cuatro = 0.04350;
                double cinco = 0.06960;

                double arl = 0;

                if (r == 1){
                
                    arl = uno * bc;
                    st -= arl;
                    
                }else if (r == 2){
                
                    arl = dos * bc;
                    st -= arl;
                    
                }else if (r == 3){
                
                    arl = tres * bc;
                    st -= arl;
                    
                }
                else if (r == 4)
                {
                    arl = cuatro * bc;
                    st -= arl;
                    
                } else if (r == 5){
                
                    arl = cinco * bc;
                    st -= arl;
                    
                }else{
                
                    Console.WriteLine("Escoge del 1-5");
                }

                //Deducciones
                p = 0.16;
                st -= p * bc;

                eps = 0.125;
                st -= eps * bc;

                Console.WriteLine("Su pension es " + p * bc);
                Console.WriteLine("Su eps es " + eps * bc);
                Console.WriteLine("Su ARL es " + arl);

                sr = st;

                Console.WriteLine("Su salario anual es " + sa);
                Console.WriteLine("Su salario real mensual es " + sr);
            }
            
            else
            {
                Console.WriteLine("Por favor ingresa D o I");
            }
            
            Console.ReadLine();
        
        }
    }
}
