﻿using Mono.Unix.Native;

namespace YaraNet.Exceptions
{
    [Serializable]
    internal class FileIOException
        : Exception
    {
        public Errno Error { get; set; }
        public string Path { get; set; }
        public FileIOException()
        {
        }

        public FileIOException(Errno error, string path) : base($"An error occured on file {path}: {error}.")
        {
            Error = error;
            Path = path;
        }
    }
}
