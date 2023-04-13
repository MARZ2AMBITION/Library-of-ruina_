using System.Xml;
using UnityEngine;

public class XMLCreator : MonoBehaviour
{
    void Start()
    {
        // XML 巩辑 积己
        XmlDocument xmlDoc = new XmlDocument();

        // 风飘 夸家 积己
        XmlElement Enemycard = xmlDoc.CreateElement("Enemycard");
        xmlDoc.AppendChild(Enemycard);

        // 磊侥 夸家 积己
        XmlElement child = xmlDoc.CreateElement("Child");
        XmlAttribute attribute = xmlDoc.CreateAttribute("Name");

        attribute.Value = "MyName";
        child.Attributes.Append(attribute);
        child.InnerText = "MyValue";
        Enemycard.AppendChild(child);

        // XML 颇老 历厘
        string path = Application.dataPath + "/Resources/MyNewXMLFile.xml";
        xmlDoc.Save(path);
    }
}

