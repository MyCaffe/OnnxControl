using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using System.Collections;
using Onnx;

/// <summary>
/// The OnnxControl namespace.
/// </summary>
namespace OnnxControl
{
    /// <summary>
    /// The PersistOnnx class is used to load and save models (including weights) in the .onnx format.
    /// </summary>
    /// <remarks>
    /// @see [ONNX Syntax](https://github.com/onnx/onnx/blob/master/docs/IR.md) for more information on the ONNX model file format.
    /// </remarks>
    public class PersistOnnx
    {
        /// <summary>
        /// The PersistOnnx constructor.
        /// </summary>
        public PersistOnnx()
        {
        }

        /// <summary>
        /// Returns the latest ONNX version supported.
        /// </summary>
        public string LatestSupportedVersion
        {
            get { return "1.7"; }
        }

        /// <summary>
        /// Load an .onnx model file and return the data in an Onnx.ModelProto.
        /// </summary>
        /// <param name="strFile">Specifies the .onnx model file.</param>
        /// <returns>The loaded model is returned in the Onnx.ModelProto which includes the model architecture, weights and optionally, input data.</returns>
        public ModelProto Load(string strFile)
        {
            using (FileStream fs = new FileStream(strFile, FileMode.Open, FileAccess.Read))
            {
                return ModelProto.Parser.ParseFrom(fs);
            }
        }

        /// <summary>
        /// Save the data within a Onnx.ModelProto to an .onnx model file.
        /// </summary>
        /// <param name="model">Specifies the model data.</param>
        /// <param name="strFile">Specifies the output file where the ModelProto data is to be saved.</param>
        public void Save(ModelProto model, string strFile)
        {
            using (FileStream fs = new FileStream(strFile, FileMode.CreateNew, FileAccess.Write))
            {
                model.WriteTo(fs);
            }
        }
    }
}
