module LogLevels

type LogMessage = {LogLevel: string; Message: string}

let getMessage (logLine: string) = 
    let parts = logLine.Split [|':'|]

    let message = { LogLevel = parts[0].TrimStart('[').TrimEnd(']').ToLower(); Message = parts[1].Trim()}

    message

let message (logLine: string): string = 
    let message = getMessage logLine

    message.Message

let logLevel(logLine: string): string = 
    let message = getMessage logLine
    message.LogLevel

let reformat(logLine: string): string =
    let message = getMessage logLine
    $"{message.Message} ({message.LogLevel})"
