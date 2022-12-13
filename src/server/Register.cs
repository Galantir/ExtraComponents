using LogicAPI.Server.Components;
using LogicWorld.Server.Circuitry;
using ExtraComponents.Shared;


namespace ExtraComponents
{
    public class Register : LogicComponent<IRegisterData>
    {
		protected override void Initialize()
		{
				base.Outputs[7].On = false;
                base.Outputs[6].On = false;
                base.Outputs[5].On = false;
                base.Outputs[4].On = false;
                base.Outputs[3].On = false;
                base.Outputs[2].On = false;
                base.Outputs[1].On = false;
                base.Outputs[0].On = false;
		}
		
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

        protected override void DoLogicUpdate()
        {
			if(base.Inputs[9].On && base.Inputs[10].On)
            {
                base.Data.D0 = base.Inputs[7].On ? (byte)1 : (byte)0;
                base.Data.D1 = base.Inputs[6].On ? (byte)1 : (byte)0;
                base.Data.D2 = base.Inputs[5].On ? (byte)1 : (byte)0;
                base.Data.D3 = base.Inputs[4].On ? (byte)1 : (byte)0;
                base.Data.D4 = base.Inputs[3].On ? (byte)1 : (byte)0;
                base.Data.D5 = base.Inputs[2].On ? (byte)1 : (byte)0;
                base.Data.D6 = base.Inputs[1].On ? (byte)1 : (byte)0;
                base.Data.D7 = base.Inputs[0].On ? (byte)1 : (byte)0;
            }
            else if(base.Inputs[8].On && base.Inputs[10].On)
            {
                base.Outputs[7].On = base.Data.D0 == 1 ? true : false;
                base.Outputs[6].On = base.Data.D1 == 1 ? true : false;
                base.Outputs[5].On = base.Data.D2 == 1 ? true : false;
                base.Outputs[4].On = base.Data.D3 == 1 ? true : false;
                base.Outputs[3].On = base.Data.D4 == 1 ? true : false;
                base.Outputs[2].On = base.Data.D5 == 1 ? true : false;
                base.Outputs[1].On = base.Data.D6 == 1 ? true : false;
                base.Outputs[0].On = base.Data.D7 == 1 ? true : false;
            }
            else
            {
                base.Outputs[7].On = false;
                base.Outputs[6].On = false;
                base.Outputs[5].On = false;
                base.Outputs[4].On = false;
                base.Outputs[3].On = false;
                base.Outputs[2].On = false;
                base.Outputs[1].On = false;
                base.Outputs[0].On = false;
            }
        }
    }
}