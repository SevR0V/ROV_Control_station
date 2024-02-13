using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace SevROVClient
{
    public class TelemetryDataEventArgs : EventArgs
    {
        public float Roll { get; private set; }
        public float Pitch { get; private set; }
        public float Yaw { get; private set; }
        public float Heading { get; private set; }
        public float Depth { get; private set; }
        public float RollSetPoint { get; private set; }
        public float PitchSetPoint { get; private set; }

        private TelemetryDataEventArgs()
        {
            
        }
        
        public static TelemetryDataEventArgs FromBytes(byte[] data)
        {

            if (data.Length != 28)
            {
                EventLog.WriteEntry("SEVROV", "Telemetry data packet has wrong format", EventLogEntryType.Warning);
                return null;
            }

            // перевод из big endian
            /*string frmt = "fffffff";
            int l = frmt.Length;
            var kek = new byte[28];
            int j = 0;
            for (int i = 0; i < l; i++)
            {
                switch (frmt[i])
                {

                    case 'f':
                        {
                            int tmp = j;
                            for (int k = tmp + 3; k >= tmp; k--)
                            {
                                kek[j] = data[k];
                                j++;
                            }
                        }
                        break;
                    case 'B':
                        {
                            kek[j] = data[j];
                            j++;
                        }
                        break;
                }
            }*/

            using (var reader = new BinaryReader(new MemoryStream(data)))
            {
                var roll = reader.ReadSingle();
                var pitch = reader.ReadSingle();
                var yaw = reader.ReadSingle();
                var heading = reader.ReadSingle();
                var depth = reader.ReadSingle();
                var rollSP = reader.ReadSingle();
                var pitchSP = reader.ReadSingle();

                return new TelemetryDataEventArgs()
                {
                    Roll = roll, 
                    Pitch = pitch,
                    Yaw = yaw,
                    Heading = heading,
                    Depth = depth,
                    RollSetPoint = rollSP,
                    PitchSetPoint = pitchSP
                };
            }
        }
    }
}