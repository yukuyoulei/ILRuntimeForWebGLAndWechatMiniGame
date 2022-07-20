using System;
using UnityEditor;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Text;

namespace ET
{
    public class OnGenerateCSProjectProcessor : AssetPostprocessor
    {
        public static string OnGeneratedCSProject(string path, string content)
        {

            if (path.EndsWith("Codes.csproj"))
            {
                content = content.Replace("<Compile Include=\"Assets\\HotfixScripts\\Empty.cs\" />", string.Empty);
                content = content.Replace("<None Include=\"Assets\\HotfixScripts\\Codes.asmdef\" />", string.Empty);
            }

            if (path.EndsWith("Codes.csproj"))
            {
                return GenerateCustomProject(path, content, @"Codes\**\*.cs");
            }

            return content;
        }

        private static string GenerateCustomProject(string path, string content, string codesPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            var newDoc = doc.Clone() as XmlDocument;

            var rootNode = newDoc.GetElementsByTagName("Project")[0];

            var itemGroup = newDoc.CreateElement("ItemGroup", newDoc.DocumentElement.NamespaceURI);
            var compile = newDoc.CreateElement("Compile", newDoc.DocumentElement.NamespaceURI);

            compile.SetAttribute("Include", codesPath);
            itemGroup.AppendChild(compile);
            rootNode.AppendChild(itemGroup);

            using (StringWriter sw = new StringWriter())
            {

                using (XmlTextWriter tx = new XmlTextWriter(sw))
                {
                    tx.Formatting = Formatting.Indented;
                    newDoc.WriteTo(tx);
                    tx.Flush();
                    return sw.GetStringBuilder().ToString();
                }
            }
        }
    }
}