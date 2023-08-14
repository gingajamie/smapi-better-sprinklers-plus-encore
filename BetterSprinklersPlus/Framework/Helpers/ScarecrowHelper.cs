using Microsoft.Xna.Framework;
using StardewValley;

namespace BetterSprinklersPlus.Framework.Helpers
{
  public static class ScarecrowHelper
  {
    public static bool IsScarecrow(this Object obj)
    {
      return obj.bigCraftable.Value && obj.Name.Contains("arecrow");
    }
    
    public static int[,] GetScarecrowGrid()
    {
      const int maxGridSize = BetterSprinklersPlusConfig.MaxGridSize;
      var grid = new int[maxGridSize, maxGridSize];
      var scarecrowCenterValue = maxGridSize / 2;
      var scarecrowCenter = new Vector2(scarecrowCenterValue, scarecrowCenterValue);
      for (var x = 0; x < maxGridSize; x++)
      {
        for (var y = 0; y < maxGridSize; y++)
        {
          var vector = new Vector2(x, y);
          grid[x, y] = Vector2.Distance(vector, scarecrowCenter) < 9f ? 1 : 0;
        }
      }

      return grid;
    }
  }
}