using LogicWorld.Interfaces;
using LogicWorld.Rendering.Chunks;
using LogicWorld.Rendering.Components;
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using ExtraComponents.Shared;
using LogicWorld.References;
using System.Text;

namespace ExtraComponents.Client
{
    public class RegisterDisplay : ComponentClientCode<IRegisterData>
    {
        private TextMeshPro _binaryTextMesh;

        protected override void SetDataDefaultValues()
        {
            base.Data.D0 = (byte)0;
            base.Data.D1 = (byte)0;
            base.Data.D2 = (byte)0;
            base.Data.D3 = (byte)0;
            base.Data.D4 = (byte)0;
            base.Data.D5 = (byte)0;
            base.Data.D6 = (byte)0;
            base.Data.D7 = (byte)0;
        }

        protected override void DataUpdate()
        {            
            StringBuilder builder = new StringBuilder();
            builder.Append(base.Data.D0.ToString());
            builder.Append(base.Data.D1.ToString());
            builder.Append(base.Data.D2.ToString());
            builder.Append(base.Data.D3.ToString());
            builder.Append(base.Data.D4.ToString());
            builder.Append(base.Data.D5.ToString());
            builder.Append(base.Data.D6.ToString());
            builder.Append(base.Data.D7.ToString());
            //string data = base.Data.D0.ToString() + base.Data.D1.ToString() + base.Data.D2.ToString() + base.Data.D3.ToString() + base.Data.D4.ToString() + base.Data.D5.ToString() + base.Data.D6.ToString() + base.Data.D7.ToString();
            _binaryTextMesh.text = builder.ToString().Reverse();
        }

        protected override void FrameUpdate()
        {

        }

        protected override IList<IDecoration> GenerateDecorations()
        {
            GameObject binaryLabel = Object.Instantiate<GameObject>(Prefabs.ComponentDecorations.DelayerText);
            GameObject readLabel = Object.Instantiate<GameObject>(Prefabs.ComponentDecorations.DelayerText);
            GameObject writeLabel = Object.Instantiate<GameObject>(Prefabs.ComponentDecorations.DelayerText);
            GameObject enableLabel = Object.Instantiate<GameObject>(Prefabs.ComponentDecorations.DelayerText); 

            _binaryTextMesh = binaryLabel.GetComponent<TextMeshPro>();
            readLabel.GetComponent<TextMeshPro>().text = "Read";
            writeLabel.GetComponent<TextMeshPro>().text = "Write";
            enableLabel.GetComponent<TextMeshPro>().text = "Enable";

            readLabel.GetComponent<TextMeshPro>().fontSize = 8;
            writeLabel.GetComponent<TextMeshPro>().fontSize = 8;
            enableLabel.GetComponent<TextMeshPro>().fontSize = 8;

            readLabel.transform.localScale = readLabel.transform.localScale * 0.5f;
            writeLabel.transform.localScale = writeLabel.transform.localScale * 0.5f;
            enableLabel.transform.localScale = enableLabel.transform.localScale * 0.5f;

            return new Decoration[] { 
                new Decoration()
                {
                    LocalPosition = new Vector3(0f, 0.3003f, 0f),
                    LocalRotation = Quaternion.Euler(90f, 180f, 0f),
                    DecorationObject = binaryLabel,
                    IncludeInModels = true
                },
                new Decoration()
                {
                    LocalPosition = new Vector3(0.9f, 0.3003f, -0.25f),
                    LocalRotation = Quaternion.Euler(90f, -90f, 0f),
                    DecorationObject = readLabel,
                    IncludeInModels = true
                },
                new Decoration()
                {
                    LocalPosition = new Vector3(0.9f, 0.3003f, 0f),
                    LocalRotation = Quaternion.Euler(90f, -90f, 0f),
                    DecorationObject = writeLabel,
                    IncludeInModels = true
                },
                new Decoration()
                {
                    LocalPosition = new Vector3(0.9f, 0.3003f, 0.25f),
                    LocalRotation = Quaternion.Euler(90f, -90f, 0f),
                    DecorationObject = enableLabel,
                    IncludeInModels = true
                }               
            };
        }       
    }
}