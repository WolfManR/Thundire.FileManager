﻿using ConsoleFileManager.Infrastructure.Commands;
using ConsoleFileManager.Infrastructure.Commands.FileSystemCLI;
using ConsoleFileManager.Infrastructure.Commands.ProgramStateCommands;

namespace ConsoleFileManager.Infrastructure.Extensions
{
    public static class CommandsRegistrator
    {
        public static InputCommandsParser CommandsRegistration(this InputCommandsParser parser) => parser
            .Register(new ListPathCommand())
            .Register(new ExitCommand())
        ;
    }
}