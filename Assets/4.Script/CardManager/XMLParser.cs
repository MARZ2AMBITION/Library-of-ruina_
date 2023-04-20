using UnityEngine;
using System.Xml;

public class XMLParser : MonoBehaviour
{
    public TextAsset xmlFile; // �Ľ��� XML ����

    void Start()
    {
        // XML ���� �ε�
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlFile.text);

        // XML ��� ��ȸ �� ���� ����
        XmlNodeList battleCardDescNodes = xmlDoc.SelectNodes("/BattleCardAbilityDescRoot/BattleCardDesc");

        foreach (XmlNode battleCardDescNode in battleCardDescNodes)
        {
            string id = battleCardDescNode.Attributes["ID"].Value;
            string localizedName = battleCardDescNode.SelectSingleNode("LocalizedName").InnerText;

            Debug.Log("ID: " + id + ", LocalizedName: " + localizedName);
        }
    }
}


