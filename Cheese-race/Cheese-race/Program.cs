using Raylib_cs;
using System.Numerics;

public class Program
{
    static string title = "Game Title"; // Window title
    static int screenWidth = 1000; // Screen width
    static int screenHeight = 800; // Screen height
    static int targetFps = 60; // Target frames-per-second

    static Rectangle player; // Player's rectangle
    static float playerSpeed = 5.0f; // Speed at which the player moves

    static void Main()
    {
        // Create a window to draw to. The arguments define width and height
        Raylib.InitWindow(screenWidth, screenHeight, title);
        // Set the target frames-per-second (FPS)
        Raylib.SetTargetFPS(targetFps);
        // Setup your game. This is a function YOU define.
        Setup();
        // Loop so long as window should not close
        while (!Raylib.WindowShouldClose())
        {
            // Enable drawing to the canvas (window)
            Raylib.BeginDrawing();
            // Clear the canvas with one color
            Raylib.ClearBackground(Raylib_cs.Color.RayWhite);
            // Your game code here. This is a function YOU define.
            Update();
            // Stop drawing to the canvas, begin displaying the frame
            Raylib.EndDrawing();
        }
        // Close the window
        Raylib.CloseWindow();
    }

    static void Setup()
    {
        // Initialize the player's rectangle
        player = new Rectangle(screenWidth / 2 - 25, screenHeight / 2 - 25, 50, 50);
    }

    static void Update()
    {
        // Move the player's rectangle based on input
        if (Raylib.IsKeyDown(KeyboardKey.W)) player.Y -= playerSpeed;
        if (Raylib.IsKeyDown(KeyboardKey.S)) player.Y += playerSpeed;
        if (Raylib.IsKeyDown(KeyboardKey.A)) player.X -= playerSpeed;
        if (Raylib.IsKeyDown(KeyboardKey.D)) player.X += playerSpeed;

        // Draw the mouses body
        Raylib.DrawRectangleRec(player, Raylib_cs.Color.Gold);
        Raylib.DrawText("THE GREAT CHEESE RACE", 200, 170, 50, Raylib_cs.Color.Black);
    }
}
