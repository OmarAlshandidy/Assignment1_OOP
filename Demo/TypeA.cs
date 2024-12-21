using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common 
{
    // What you can write  inside the NameSpace ? 
    // 1-calss
    //2- Struct 
    //3- interface
    //4-Enum 
    //------------------------------
    // Allowed Acces Modifiers inside the name space
    // 1- Internal 
    // 2- Public 

    public class TypeA
    {
        // What you Can write inside The class Or Struct 
        // 1- Attribute (Fielda) -> Member Varabiles
        // 2- Properities ( Full Property => Auomatic Prooperty =>indexer)
        // 3- Functions(Constructor => Getter /Setter => Method )
        //4-Event 
        //--------------------------------------------------------
        // Alowed Acces Modifiers Inside The Class 
        //1- Private 
        //2- Private Protected 
        // 3- Protected 
        // 4- Internal 
        // 5- Internal Protected 
        // 6- Public 
        #region Atrribute 
        int x ,y ;
        // internal int y;
        // public int x ;
        #endregion
        #region interface
        // What You can write inside the interface 
        // 1- Signature for propert 
        // 2- Signature For Method 
        // 3 - Default Implemente Method 
        #endregion


    }
}
