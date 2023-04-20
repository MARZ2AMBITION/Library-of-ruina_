using UnityEngine;
using System.Xml;

public class XMLParser : MonoBehaviour
{
    public TextAsset xmlFile; // 파싱할 XML 파일

    void Start()
    {
        // XML 파일 로드
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlFile.text);

        // XML 요소 순회 및 정보 추출
        XmlNodeList battleCardDescNodes = xmlDoc.SelectNodes("/BattleCardAbilityDescRoot/BattleCardDesc");

        foreach (XmlNode battleCardDescNode in battleCardDescNodes)
        {
            string id = battleCardDescNode.Attributes["ID"].Value;
            string localizedName = battleCardDescNode.SelectSingleNode("LocalizedName").InnerText;

            Debug.Log("ID: " + id + ", LocalizedName: " + localizedName);
        }
    }
}


