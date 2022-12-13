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
    public class ALUDisplay : ComponentClientCode<IALUData>
    {

        private TextMeshPro _binaryTextMesh;

        protected override void SetDataDefaultValues()
        {
            base.Data.A0 = (byte)0;
            base.Data.A1 = (byte)0;
            base.Data.A2 = (byte)0;
            base.Data.A3 = (byte)0;
            base.Data.A4 = (byte)0;
            base.Data.A5 = (byte)0;
            base.Data.A6 = (byte)0;
            base.Data.A7 = (byte)0;

            base.Data.B0 = (byte)0;
            base.Data.B1 = (byte)0;
            base.Data.B2 = (byte)0;
            base.Data.B3 = (byte)0;
            base.Data.B4 = (byte)0;
            base.Data.B5 = (byte)0;
            base.Data.B6 = (byte)0;
            base.Data.B7 = (byte)0;
        }

        protected override void DataUpdate()
        {
            _binaryTextMesh.text = "test";
        }

        protected override void FrameUpdate()
        {

        }

        protected override IList<IDecoration> GenerateDecorations()
        {
            GameObject binaryLabel = Object.Instantiate<GameObject>(Prefabs.ComponentDecorations.DelayerText);
            _binaryTextMesh = binaryLabel.GetComponent<TextMeshPro>();

            return new Decoration[] {
                new Decoration()
                {
                    LocalPosition = new Vector3(0f, 0.3003f, 0f),
                    LocalRotation = Quaternion.Euler(90f, 180f, 0f),
                    DecorationObject = binaryLabel,
                    IncludeInModels = true
                }
            };
        }
    }
}