using Siftables.Sifteo;
using System;

namespace ChangingColorsApp
{
  public class ChangingColorsApp : BaseApp
  {

      private int _currentCubeIndex;

        override public void Setup()
        {
            this._currentCubeIndex = 0;
            foreach (Cube cube in Cubes)
            {
                cube.FillScreen(Color.White);
            }
        }

        public override void Tick()
        {
            foreach (Cube c in this.Cubes)
            {
                int num = c.Neighbors.Count;
                if (num == 0) c.FillScreen(Color.Black);
                else if (num == 1) c.FillScreen(new Color(255, 0, 0)); // red
                else if (num == 2) c.FillScreen(new Color(255, 255, 0)); // yellow
                else if (num == 3) c.FillScreen(new Color(0, 0, 255)); // blue
                else if (num == 4) c.FillScreen(new Color(0, 255, 0)); // green
            }

/*		override public void Tick()
        {
            Random rand = new Random();
            int r = rand.Next(0, 256);
            int g = rand.Next(0, 256);
            int b = rand.Next(0, 256);
            Color color = new Color((byte) r, (byte) g, (byte) b);

            Cube nextCube = this.Cubes[this._currentCubeIndex];
            nextCube.FillScreen(color);

            this._currentCubeIndex = (this._currentCubeIndex + 1) % this.Cubes.Count;
*/
        }
    /*
    private int currentCubeIndex;

    // called during intitialization, before the game has started to run
    override public void Setup()
    {
        this.currentCubeIndex = 0;

        foreach (Cube cube in this.Cubes)
        {
            cube.FillScreen(Color.Black);
            //cube.Paint();
        }
    }

    override public void Tick()
    {
        Random rand = new Random();
        int r = rand.Next(0, 256);
        int g = rand.Next(0, 256);
        int b = rand.Next(0, 256);*/
        /*int r = 200;
        int g = 100;
        int b = 0;*/
        /*Color color = new Color((byte) r, (byte) g, (byte) b);

        Cube nextCube = this.Cubes[this.currentCubeIndex];
        nextCube.FillScreen(color);
        //nextCube.Paint();

        this.currentCubeIndex = (this.currentCubeIndex + 1) % this.Cubes.Count;
    } */
  }
}
