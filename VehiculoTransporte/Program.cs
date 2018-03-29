    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dealer.Vehiculos objVehiculo;
                Dealer.Personas objPersona;
                Dealer.Sucursales objSucursal;
                Dealer.Ventas objVentas;
                Dealer.Computos objComputo;
                double cantidad = 0;
                
                short opcion;
                int salir,id, precio, codigo, salario, dinerov, comision;
                string marca, modelo,tipov, entrega;
                string nombre,funcion, ingreso;
                string sucursal, estado, fechaap;
                string vehiculo, vendedor, comprador;
                string dineroxf, masv;
              
                do
                {
                    Console.WriteLine("\n Autos AAAA Ventas de vehiculos nuevos y usados\n\n Menu del Usuario \n");
                    Console.WriteLine("\n 1- Catalogo de vehiculos");
                    Console.WriteLine("\n 2- Definicion de individuos");
                    Console.WriteLine("\n 3- Informacion de las sucursales");
                    Console.WriteLine("\n 4- Ventas");
                    Console.WriteLine("\n 5- Computos");
                    Console.WriteLine("\n 6- Buscar");
                    Console.WriteLine("\n 7- Salir \n");
                    salir = int.Parse(Console.ReadLine());
                    switch (salir)
                    {
                        case 1:
                            Console.WriteLine("|----------------------------------------------------------|");
                            Console.Write("|\t Introduzca la Cantidad de Vehiculos a registrar = ");
                            cantidad = int.Parse(Console.ReadLine());
                            for (int Iter = 0; Iter < cantidad; Iter++)
                            {
                                Console.WriteLine("-----------------------Vehiculo[" + Iter.ToString() + "/" + cantidad.ToString() + "]");
                                Console.Write(" \n Nombre de la marca: ");
                                marca = Console.ReadLine();
                                Console.Write("\n Nombre del modelo: ");
                                modelo = Console.ReadLine();
                                Console.Write("\n Tipo de vehiculo: ");
                                tipov = Console.ReadLine();
                                Console.Write("\n Estado del vehiculo: ");
                                entrega = Console.ReadLine();
                                objVehiculo = new Dealer.Vehiculos(marca, modelo, tipov, entrega);
                                Console.Write("Desea guardarlo? \n [1-si 0-no] \n");
                                opcion = short.Parse(Console.ReadLine());
                                if (opcion == 1)
                                    if (objVehiculo.Grabar())
                                        Console.Write("\n se ha guardado existosamente \n ");
                                    else
                                        Console.Write("\n ERROR!!!-->" + objVehiculo.getMensaje());
                                objVehiculo = null;
                            }
                            objVehiculo = new Dealer.Vehiculos();

                            Console.WriteLine("\t Datos: \n");
                            Console.WriteLine(objVehiculo.AlltableString());
                            objVehiculo = null;
                            break;
                        case 2:
                             Console.WriteLine("|----------------------------------------|");
                             Console.Write("|\t Introduzca la Cantidad de Personas  = ");
                             cantidad = int.Parse(Console.ReadLine());
                              for (int Iter = 0; Iter < cantidad; Iter++)
                                  {
                                     Console.WriteLine("-----------------------Personas[" + Iter.ToString() + "/" + cantidad.ToString() + "]");
                                     Console.Write(" \n Nombre de la persona: ");
                                     nombre = Console.ReadLine();
                                     Console.Write("\n Funcion de la persona: ");
                                     funcion = Console.ReadLine();
                                     Console.Write(" \n Codigo del empleado(Solo vendedor): ");
                                     codigo = int.Parse(Console.ReadLine());
                                     Console.Write(" \n Salario del empleado(Solo vendedor): ");
                                     salario = int.Parse(Console.ReadLine());
                                     Console.Write("\n Fecha de ingreso(Solo vendedor): ");
                                     ingreso = Console.ReadLine();
                                  objPersona = new Dealer.Personas(nombre, funcion, codigo, salario, ingreso);       
                                     Console.Write("Desea guardarlo? \n [1-si 0-no] \n");
                                     opcion = short.Parse(Console.ReadLine());
                                     if (opcion == 1)
                                          if (objPersona.Grabar())
                                                 Console.Write("\n se ha guardado existosamente \n ");
                                              else
                                              Console.Write("\n ERROR!!!-->" + objPersona.getMensaje());
                                     objPersona = null;            
                                        }
                              objPersona = new Dealer.Personas();

                              Console.WriteLine("\t Datos: \n");
                                    Console.WriteLine(objPersona.AlltableString());
                                    objPersona = null;
                            break;
                        case 3:
                             Console.WriteLine("|----------------------------------------|");
                             Console.Write("|\t Introduzca la Cantidad de sucursales cuya informacion guardara = ");
                             cantidad = int.Parse(Console.ReadLine());
                              for (int Iter = 0; Iter < cantidad; Iter++)
                                  {
                                     Console.WriteLine("-----------------------Sucursales[" + Iter.ToString() + "/" + cantidad.ToString() + "]");
                                     Console.Write(" \n Sucursal: ");
                                     sucursal = Console.ReadLine();
                                     Console.Write("\n Estado: ");
                                     estado = Console.ReadLine();
                                     Console.Write(" \n Fecha de inauguracion: ");
                                     fechaap = Console.ReadLine();
                                     objSucursal = new Dealer.Sucursales(sucursal, estado, fechaap);       
                                     Console.Write("Desea guardarlo? \n [1-si 0-no] \n");
                                     opcion = short.Parse(Console.ReadLine());
                                     if (opcion == 1)
                                          if (objSucursal.Grabar())
                                                 Console.Write("\n se ha guardado existosamente \n ");
                                              else
                                              Console.Write("\n ERROR!!!-->" + objSucursal.getMensaje());
                                     objSucursal = null;            
                                        }
                              objSucursal = new Dealer.Sucursales();

                              Console.WriteLine("\t Datos:\n");
                                    Console.WriteLine(objSucursal.AllTableString());
                                    objSucursal = null;
                            break;

                        case 4:
                            Console.WriteLine("|----------------------------------------|");
                            Console.Write("|\t Introduzca el numero de ventas = ");
                            cantidad = int.Parse(Console.ReadLine());
                            for (int Iter = 0; Iter < cantidad; Iter++)
                            {
                                Console.WriteLine("-----------------------Ventas[" + Iter.ToString() + "/" + cantidad.ToString() + "]");
                                Console.Write(" \n Vehiculo: ");
                                vehiculo = Console.ReadLine();
                                Console.Write("\n Vendedor: ");
                                vendedor = Console.ReadLine();
                                Console.Write("\n Comprador: ");
                                comprador = Console.ReadLine();
                                Console.Write(" \n Precio: ");
                                precio = int.Parse(Console.ReadLine());
                                objVentas = new Dealer.Ventas(vehiculo, vendedor, comprador, precio);
                                Console.Write("Desea guardarlo? \n [1-si 0-no] \n");
                                opcion = short.Parse(Console.ReadLine());
                                if (opcion == 1)
                                    if (objVentas.Grabar())
                                        Console.Write("\n se ha guardado existosamente \n ");
                                    else
                                        Console.Write("\n ERROR!!!-->" + objVentas.getMensaje());
                                objVentas = null;
                            }
                            objVentas = new Dealer.Ventas();

                            Console.WriteLine("\t Datos: \n");
                            Console.WriteLine(objVentas.AlltableString());
                            objVentas = null;
                            break;

                        case 5:
                            Console.WriteLine("|----------------------------------------|");
                            Console.Write("|\t Introduzca la Cantidad de computos a registrar = ");
                            cantidad = int.Parse(Console.ReadLine());
                            for (int Iter = 0; Iter < cantidad; Iter++)
                            {
                                Console.WriteLine("-----------------------Computos[" + Iter.ToString() + "/" + cantidad.ToString() + "]");
                                Console.Write(" \n Total de dinero por ventas: ");
                                dinerov = int.Parse(Console.ReadLine());
                                Console.Write("\n Total de comision a vendedores (9.5%): ");
                                comision = int.Parse(Console.ReadLine());
                                Console.Write("\n Total de dinero en un rango de fecha: ");
                                dineroxf = Console.ReadLine();
                                Console.Write("\n 3 marcas mas vendidas: ");
                                masv = Console.ReadLine();

                                objComputo = new Dealer.Computos(dinerov, comision, dineroxf, masv);
                                Console.Write("Desea guardarlo? \n [1-si 0-no] \n");
                                opcion = short.Parse(Console.ReadLine());
                                if (opcion == 1)
                                    if (objComputo.Grabar())
                                        Console.Write("\n se ha guardado existosamente \n ");
                                    else
                                        Console.Write("\n ERROR!!!-->" + objComputo.getMensaje());
                                objComputo = null;
                            }
                            objComputo = new Dealer.Computos();

                            Console.WriteLine("\t Datos:\n");
                            Console.WriteLine(objComputo.AlltableString());
                            objComputo = null;
                            break;
                        case 6:
                            Console.WriteLine("Indroduzca el Id a buscar: ");
                            id = int.Parse(Console.ReadLine());
                            new Vehiculos().buscar(id);
                            new Personas().buscar(id);
                            new Sucursales().buscar(id);
                            new Ventas().buscar(id);
                            new Computos().buscar(id);

                            objVehiculo = new Dealer.Vehiculos();
                            objPersona = new Dealer.Personas();
                            objSucursal = new Dealer.Sucursales();
                            objVentas = new Dealer.Ventas();
                            objComputo = new Dealer.Computos();


                            Console.WriteLine("\t Datos:\n");
                            Console.WriteLine(objVehiculo.AllString());
                            Console.WriteLine(objPersona.AllString());
                            Console.WriteLine(objSucursal.AllString());
                            Console.WriteLine(objVentas.AllString());
                            Console.WriteLine(objComputo.AllString());

                            objVehiculo = null;
                            objPersona = null;
                            objSucursal = null;
                            objVentas = null;
                            objComputo = null;

                            break;
                        default:
                            Console.WriteLine("Error al Ingresar ");
                            Console.ReadKey();
                            break;
                    }
                }
                while (salir != 6);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
