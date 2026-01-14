namespace KaitoKid.Utilities.Interfaces
{
    public interface IAssetLocation
    {
        string GameName { get; }
        string ItemName { get; }
        int GetSeed();
    }
}
