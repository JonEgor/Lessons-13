using Lessons_13;
using Lessons13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



var outcomejes = ObjectExtentions.ReadFromJsonFile<Squad>(@"D:/outcome.json"); //  

ObjectExtentions.WriteToJsonFile<Squad>(@"D:/outcome.json", outcomejes);  //сохранение  Json 


//ObjectExtentions.WriteToXmlFile<Squad>(@"C:/resultxml.xml", outcomexml);

//var outcomexml = ObjectExtentions.ReadFromXmlFile<Squad>(@"C:/resultxml.xml");

