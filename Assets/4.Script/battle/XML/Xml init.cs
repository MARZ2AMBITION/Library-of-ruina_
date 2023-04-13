using System.Xml;
using UnityEngine;

public class XMLCreator : MonoBehaviour
{
    void Start()
    {
        // XML ���� ����
        XmlDocument xmlDoc = new XmlDocument();

        // ��Ʈ ��� ����
        XmlElement Enemycard = xmlDoc.CreateElement("Enemycard");
        xmlDoc.AppendChild(Enemycard);

        // �ڽ� ��� ����
        XmlElement child = xmlDoc.CreateElement("Child");
        XmlAttribute attribute = xmlDoc.CreateAttribute("Name");

        attribute.Value = "MyName";
        child.Attributes.Append(attribute);
        child.InnerText = "MyValue";
        Enemycard.AppendChild(child);

        // XML ���� ����
        string path = Application.dataPath + "/Resources/MyNewXMLFile.xml";
        xmlDoc.Save(path);
    }
}

