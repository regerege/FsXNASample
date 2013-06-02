(*
かんたんXNA4.0　その３　2D画像の表示
http://memeplex.blog.shinobi.jp/xna/%E3%81%8B%E3%82%93%E3%81%9F%E3%82%93xna4.0%E3%80%80%E3%81%9D%E3%81%AE%EF%BC%93%E3%80%802d%E7%94%BB%E5%83%8F%E3%81%AE%E8%A1%A8%E7%A4%BA
*)
module Sample03

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

type MyGame() as x =
    inherit Game()
    let graphics = lazy new GraphicsDeviceManager(x)
    let spriteBatch = lazy new SpriteBatch(x.GraphicsDevice)
    let texture = lazy new Texture2D(x.GraphicsDevice, 3, 1)
    do
        graphics.Force() |> ignore
    override x.LoadContent() =
        spriteBatch.Force() |> ignore
        texture.Force() |> ignore
        texture.Value.SetData([| Color.Navy; Color.White; Color.Red |])
    override x.Draw time =
        x.GraphicsDevice.Clear(Color.CornflowerBlue)
        spriteBatch.Value.Begin()
        spriteBatch.Value.Draw(texture.Value, new Rectangle(0,0,100,100), Color.White)
        spriteBatch.Value.End()

let run() =
    use game = new MyGame()
    game.Run()
