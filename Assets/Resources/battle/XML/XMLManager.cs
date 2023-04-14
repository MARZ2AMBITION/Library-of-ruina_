using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class XMLManager : MonoBehaviour
{
    static void Main(string[] args)
    {
        // XmlDocument 인스턴스 생성
        XmlDocument xmlDoc = new XmlDocument();

        // XML 선언 추가
        XmlNode xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        xmlDoc.AppendChild(xmlDeclaration);

        // 루트 요소 추가
        XmlNode rootNode = xmlDoc.CreateElement("BattleDialogRoot");
        xmlDoc.AppendChild(rootNode);

        // GroupName 요소 추가
        XmlNode groupNameNode = xmlDoc.CreateElement("GroupName");
        groupNameNode.InnerText = "The Blue Reverberation2 Roland";
        rootNode.AppendChild(groupNameNode);


        // Create a new "Character" element with "ID" attribute
        XmlElement characterElement1 = xmlDoc.CreateElement("Character");
        XmlAttribute idAttribute1 = xmlDoc.CreateAttribute("ID");
        idAttribute1.Value = "R_A_Argalia";
        characterElement1.Attributes.Append(idAttribute1);

        // Add the "Type" elements to the "Character" element
        XmlElement typeElement1_1 = xmlDoc.CreateElement("Type");
        XmlAttribute typeAttribute1_1 = xmlDoc.CreateAttribute("ID");
        typeAttribute1_1.Value = "START_BATTLE";
        typeElement1_1.Attributes.Append(typeAttribute1_1);
        characterElement1.AppendChild(typeElement1_1);

        // Add the "BattleDialog" elements to the "Type" element
        XmlElement battleDialogElement1_1_1 = xmlDoc.CreateElement("BattleDialog");
        XmlAttribute battleDialogAttribute1_1_1 = xmlDoc.CreateAttribute("ID");
        battleDialogAttribute1_1_1.Value = "START_BATTLE_0";
        battleDialogElement1_1_1.Attributes.Append(battleDialogAttribute1_1_1);
        battleDialogElement1_1_1.InnerText = "무대가 우리를 부르고 있어… 드디어 막이 오르려나?";
        typeElement1_1.AppendChild(battleDialogElement1_1_1);

        // Add the "Type" elements to the "Character" element
        XmlElement typeElement1_2 = xmlDoc.CreateElement("Type");
        XmlAttribute typeAttribute1_2 = xmlDoc.CreateAttribute("ID");
        typeAttribute1_2.Value = "BATTLE_VICTORY";
        typeElement1_2.Attributes.Append(typeAttribute1_2);
        characterElement1.AppendChild(typeElement1_2);

        // Add the "Death" elements to the "Character" element
        XmlElement typeElement1_3 = xmlDoc.CreateElement("Type");
        XmlAttribute typeAttribute1_3 = xmlDoc.CreateAttribute("ID");
        typeAttribute1_3.Value = "DEATH";
        typeElement1_3.Attributes.Append(typeAttribute1_3);
        characterElement1.AppendChild(typeElement1_3);

        // Add the "BattleDialog" elements to the "Type" element
        XmlElement battleDialogElement1_3_1 = xmlDoc.CreateElement("BattleDialog");
        XmlAttribute battleDialogAttribute1_3_1 = xmlDoc.CreateAttribute("ID");
        battleDialogAttribute1_3_1.Value = "DEATH_0";
        battleDialogElement1_3_1.Attributes.Append(battleDialogAttribute1_3_1);
        battleDialogElement1_3_1.InnerText = "롤랑… 이렇게 끝나지는 않을 거야…";
        typeElement1_3.AppendChild(battleDialogElement1_3_1);

        // Add the "Type" elements to the "Character" element
        XmlElement typeElement1_4 = xmlDoc.CreateElement("Type");
        XmlAttribute typeAttribute1_4 = xmlDoc.CreateAttribute("ID");
        typeAttribute1_4.Value = "COLLEAGUE_DEATH";
        typeElement1_4.Attributes.Append(typeAttribute1_4);
        // characterElement1.AppendChild(typeElement1
        




                string path = Application.dataPath + "/Resources/BattleDialog/BattleDialog.xml";
        xmlDoc.Save(path);
    }
    
}
