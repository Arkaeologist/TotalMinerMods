using Craig.TotalMiner.API;

public class TMPluginProvider : ITMPluginProvider
{
    public ITMPlugIn GetPlugin()
    {
        return new CraigMod1.CraigMod1();
    }

    public ITMPlugInBlocks GetPluginBlocks()
    {
        return null;
    }

    public ITMPlugInArcade GetPluginArcade()
    {
        return null;
    }

    public ITMPlugInGUI GetPluginGUI()
    {
        return null;
    }
}
