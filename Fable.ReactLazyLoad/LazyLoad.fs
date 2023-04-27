module Fable.ReactLazyLoad

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.ReactBindings

type ILazyLoadOption = interface end

[<Erase>]
type LazyLoadOption =
    /// The offset option allows you to specify how far below, above, to the left, and to the right of the viewport you want to begin displaying your content. If you specify 0, your content will be displayed as soon as it is visible in the viewport, if you want to load 1000px below or above the viewport, use 1000.
    ///
    /// Default: 0
    static member inline offset (value: int): ILazyLoadOption = !!("offset", value)

    /// The offset option allows you to specify how far below, above, to the left, and to the right of the viewport you want to begin displaying your content. If you specify 0, your content will be displayed as soon as it is visible in the viewport, if you want to load 1000px below or above the viewport, use 1000.
    ///
    /// Default: 0
    static member inline offset (value: string): ILazyLoadOption = !!("offset", value)

    /// This threshold option allows you to specify how much of the element must be shown on the screen prior to loading. This requires a width and height to be set on the <LazyLoad> component in order for the browser to calcualte the viewable area.
    ///
    /// Default: 0
    static member inline threshold (value: int): ILazyLoadOption = !!("threshold", value)

    /// The height option allows you to set the element's height even when it has no content.
    static member inline height (value: int): ILazyLoadOption = !!("height", value)

    /// The height option allows you to set the element's height even when it has no content.
    static member inline height (value: string): ILazyLoadOption = !!("height", value)

    /// The width option allows you to set the element's width even when it has no content.
    static member inline width (value: int): ILazyLoadOption = !!("width", value)

    /// The width option allows you to set the element's width even when it has no content.
    static member inline width (value: string): ILazyLoadOption = !!("width", value)

    /// A callback function to execute when the content appears on the screen.
    static member inline onContentVisible (callback: unit -> unit): ILazyLoadOption = !!("onContentVisible", callback)

[<Erase>]
type LazyLoad =
    static member inline render (options: seq<ILazyLoadOption>) (children: seq<ReactElement>) = React.createElement (importDefault "react-lazy-load", createObj !!options, children)
