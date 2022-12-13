using LogicAPI.Server.Components;
using LogicWorld.Server.Circuitry;
using ExtraComponents.Shared;


namespace ExtraComponents
{
    public class ALU : LogicComponent<IALUData>
    {
        protected override void Initialize()
        {
            base.Ouputs[0].On = false;
        }

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

        protected override void DoLogicUpdate()
        {
            base.Ouputs[0].On = base.Inputs[0].On;
        }
    }
}