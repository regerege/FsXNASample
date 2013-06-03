(*
かんたんXNA4.0　その４　画像ファイルを表示
http://memeplex.blog.shinobi.jp/xna/%E3%81%8B%E3%82%93%E3%81%9F%E3%82%93xna4.0%E3%80%80%E3%81%9D%E3%81%AE%EF%BC%94%E3%80%80%E7%94%BB%E5%83%8F%E3%83%95%E3%82%A1%E3%82%A4%E3%83%AB%E3%82%92%E8%A1%A8%E7%A4%BA
*)
module Sample04

open System.IO
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

type MyGame() as x =
    inherit Game()
    let graphics = lazy new GraphicsDeviceManager(x)
    let spriteBatch = lazy new SpriteBatch(x.GraphicsDevice)
    let texture = lazy Texture2D.FromStream(x.GraphicsDevice, File.Open("04_penguins.jpg", FileMode.Open))
    do
        graphics.Force() |> ignore
    override x.LoadContent() =
        spriteBatch.Force() |> ignore
        texture.Force() |> ignore
    override x.Draw time =
        x.GraphicsDevice.Clear(Color.CornflowerBlue)
        spriteBatch.Value.Begin()
        spriteBatch.Value.Draw(texture.Value, new Rectangle(0,0,400,300), Color.White)
        spriteBatch.Value.End()

let run() =
    use game = new MyGame()
    game.Run()

