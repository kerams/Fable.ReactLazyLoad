# Fable.ReactLazyLoad

Fable bindings for [react-lazy-load](https://github.com/loktar00/react-lazy-load) ([NPM package](https://npmjs.org/package/react-lazy-load)) version 4.0.0+.

## Nuget package
[![Nuget](https://img.shields.io/nuget/v/Fable.ReactLazyLoad.svg?colorB=green)](https://www.nuget.org/packages/Fable.ReactLazyLoad)

## Installation with [Femto](https://github.com/Zaid-Ajaj/Femto)

```
femto install Fable.ReactLazyLoad
```

## Standard installation

Nuget package

```
paket add Fable.ReactLazyLoad -p YourProject.fsproj
```

NPM package

```
npm install react-lazy-load@4.0.1
```

## Usage

[Supported props.](https://github.com/loktar00/react-lazy-load#props)

```fsharp
open Fable.React
open Fable.ReactLazyLoad

let lazyLoadedImage (src: string) =
    LazyLoad.render [ LazyLoadOption.onContentVisible (fun () -> printfn "I was lazy-loaded just now!") ] [
        img [ Src src ]
    ]
```