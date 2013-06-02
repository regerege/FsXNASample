(*
かんたんXNA4.0　その２　背景のクリア
http://memeplex.blog.shinobi.jp/xna/%E3%81%8B%E3%82%93%E3%81%9F%E3%82%93xna4.0%E3%80%80%E3%81%9D%E3%81%AE%EF%BC%92%E3%80%80%E8%83%8C%E6%99%AF%E3%81%AE%E3%82%AF%E3%83%AA%E3%82%A2
*)
module Sample02

open Microsoft.Xna.Framework

type MyGame() as x =
    inherit Game()
    let graphics = lazy(new GraphicsDeviceManager(x))
    do
        graphics.Force() |> ignore
    override x.Draw time =
        x.GraphicsDevice.Clear(Color.CornflowerBlue)

let run() =
    use game = new MyGame()
    game.Run()
