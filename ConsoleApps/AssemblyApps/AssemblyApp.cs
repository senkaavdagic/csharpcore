using System.Reflection;
using System;
using System.Collections;
namespace AssemblyApps
{
    public class AssemblyApp
    {
        static void  Main(string[] argss)
        {     
            Type t = typeof(AssemblyApp);
            System.Data.DataSet dataSet;
            //Assembly assem = Assembly.GetAssembly(t);
            Assembly assem = Assembly.GetEntryAssembly();
            foreach(var a in assem.GetReferencedAssemblies())
            {
                var assemb = Assembly.Load(new AssemblyName(a.FullName));
                var deftypes =assemb.DefinedTypes;     
                foreach (var dt in deftypes)
                {
                    
                    //var declmeth = dt.DeclaredMethods;
                    var declmeth = dt.DeclaredProperties;
                    foreach (var dm in declmeth)
                    {
                        Console.WriteLine(a.Name + " @ " + dm.Name);
                    }
                    
                }   
            }
            
                                
        }
    }    
}
