// requirements:
//   .NET Core or .NET Runtime
//
// usage:
//   1. install dotnet-script
//     dotnet tool install -g dotnet-script
//   2. run this script
//     dotnet script ./modular-diagram-reformatter.csx

using System;
using System.Xml;
using System.Xml.Linq;
using System.Text;

const string file = "./modular-diagram.svg";

var doc = XDocument.Load(file);
var settings = new XmlWriterSettings() {
  Encoding = new UTF8Encoding(false),
  Indent = true,
  IndentChars = " ",
  NewLineChars = "\n",
};

using (var writer = XmlWriter.Create(file, settings)) {
  doc.Save(writer);
}

