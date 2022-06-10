using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tuftex_XML_Creator
{
    class createXML
    {
        public void createXMLRun(string path, string styleNumber, string styleName, string colorNumber, string colorName, string fiber, string pattern, string parRating, string width, string baseLabel, string[] bugs)
        {
            string[] xmlLines1 = {
                                    "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>",
                                    "<work-order-detail id=\"Create\">",
                                    "   <styles>",
                                    "       <style>",
                                    "           <durability>" + parRating + "</durability>",
                                    "           <width>" + width + "</width>",
                                    "           <pattern-repeat>" + pattern + "</pattern-repeat>",
                                    "           <style-id>" + styleNumber + "</style-id>",
                                    "           <name>" + styleName + "</name>",
                                    "           <fiber-content>" + fiber + "</fiber-content>",
                                    "           <labels>",
                                    "               <main-label sku=\"0000" + baseLabel + "\"></main-label>",
                                    "           </labels>",
                                    "           <bugs>"
                                };

            string[] xmlLines2 = { 
		                            "           </bugs>",
		                            "           <colors>", 
		                            "               <color label-required=\"yes\" sequence=\"0\">",
		                            "                   <color-id>" + colorNumber + "</color-id>",
		                            "                   <name>" + colorName + "</name>",
		                            "               </color>",
		                            "           </colors>",
		                            "       </style>",
		                            "   </styles>",
		                            "</work-order-detail>"
                                 };


            using (System.IO.StreamWriter xmlFile = new System.IO.StreamWriter(path + "\\" + styleNumber + ".xml", true))
            {
                foreach (string xmlLine in xmlLines1)
                {
                    xmlFile.WriteLine(xmlLine);
                }

                foreach (string bug in bugs)
                {
                    xmlFile.WriteLine("<bug sku=\"" + bug + "\"></bug>");
                }

                foreach (string xmlLine in xmlLines2)
                {
                    xmlFile.WriteLine(xmlLine);
                }
            }
        }
    }
}
