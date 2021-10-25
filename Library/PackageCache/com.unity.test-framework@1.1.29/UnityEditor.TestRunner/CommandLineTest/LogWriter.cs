        private StreamWriter CreateLogFile(string path)
        {
            Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "Creating {0} device log: {1}", m_DeviceID, path);
            StreamWriter streamWriter = null;
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(Path.GetDirectoryName(path));

                streamWriter = File.CreateText(path);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Creating device log {path} file failed.");
                Debug.LogException(ex);
            }

            return streamWriter;
        }

        private string GetLogFilePath(string lgosDirectory, string deviceID, string logID)
        {
            var fileName = "Device-" + deviceID + "-" + logID + ".txt";
            fileName = string.Join("_", fileName.Split(Path.GetInvalidFileNameChars()));
            return Paths.Combine(lgosDirectory, fileName);
        }
    }
}
