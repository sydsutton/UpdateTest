module App

open Elmish
open Elmish.React
open Fable.Core
open Feliz
open Feliz.UseElmish
open UseElmish
open Browser.Dom

let root = ReactDOM.createRoot (document.getElementById "elmish-app")
root.render(React.strictMode [Index.View()])