﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnnxControl
{
    /// <summary>
    /// The OnnxDefinitions contains standard ONNX definitions that are missed during the conversion from proto to .cs.
    /// </summary>
    public class OnnxDefinitions
    {
        Dictionary<OPERATORS, int> m_rgOperatorVersions = new Dictionary<OPERATORS, int>();

        /// <summary>
        /// Defines the ONNX basic data types as defined  by TensorProto on onnx.proto3.
        /// </summary>
        public enum DataType
        {
            /// <summary>
            /// Specifies an undefined data type.
            /// </summary>
            UNDEFINED = 0,
            /// <summary>
            /// Specifies a basic float.
            /// </summary>
            FLOAT = 1,   
            /// <summary>
            /// Specifies a basic unint8.
            /// </summary>
            UINT8 = 2,  
            /// <summary>
            /// Specifies a basic int8
            /// </summary>
            INT8 = 3,   
            /// <summary>
            /// Specifies a basic unint16.
            /// </summary>
            UINT16 = 4,  
            /// <summary>
            /// Specifies a basic int16.
            /// </summary>
            INT16 = 5,  
            /// <summary>
            /// Specifies a basic int32 (or int).
            /// </summary>
            INT32 = 6,   
            /// <summary>
            /// Specifies a basic int64 (or long).
            /// </summary>
            INT64 = 7,   
            /// <summary>
            /// Specifies a basic string.
            /// </summary>
            STRING = 8,  
            /// <summary>
            /// Specifies a basic boolean (true or false).
            /// </summary>
            BOOL = 9,

            /// <summary>
            /// IEEE754 half-precision floating-point format (16 bits wide).
            /// This format has 1 sign bit, 5 exponent bits, and 10 mantissa bits.
            /// </summary>
            FLOAT16 = 10,

            /// <summary>
            /// Specifies a double value.
            /// </summary>
            DOUBLE = 11,
            /// <summary>
            /// Specifies an unsigned int.
            /// </summary>
            UINT32 = 12,
            /// <summary>
            /// Specifies an unsigned long.
            /// </summary>
            UINT64 = 13,
            /// <summary>
            /// Complex with float32 real and imaginary components
            /// </summary>
            COMPLEX64 = 14,
            /// <summary>
            /// Complex with float64 real and imaginary components
            /// </summary>
            COMPLEX128 = 15,

            /// <summary>
            /// Non-IEEE floating-point format based on IEEE754 single-precision
            /// floating-point number truncated to 16 bits.
            /// This format has 1 sign bit, 8 exponent bits, and 7 mantissa bits.
            /// </summary>
            BFLOAT16 = 16
        }

        /// <summary>
        /// Defines the operators that are converted to string as specified as the NodeProto OpType value.
        /// </summary>
        /// <remarks>
        /// @see [ONNX Operators](https://github.com/onnx/onnx/blob/master/docs/Operators.md) for more documentation on operators.
        /// </remarks>
#pragma warning disable 1591
        public enum OPERATORS
        {
            Abs,
            Acos,
            Acosh,
            Add,
            And,
            ArgMax,
            ArgMin,
            Asin,
            Asinh,
            Atan,
            Atanh,
            /// <summary>
            /// @see [AveragePool Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#AveragePool)
            /// </summary>
            AveragePool,
            BatchNormalization,
            BitShift,
            Cast,
            Ceil,
            Clip,
            Compress,
            Concat,
            ConcatFromSequence,
            Constant,
            ConstantOfShape,
            /// <summary>
            /// @see [Conv Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Conv)
            /// </summary>
            Conv,
            ConvInteger,
            ConvTranspose,
            Cos,
            Cosh,
            CumSum,
            DepthToSpace,
            DequantizeLinear,
            Det,
            Div,
            Dropout,
            Einsum,
            Elu,
            Equal,
            Erf,
            Exp,
            Expand,
            EyeLike,
            Flatten,
            Floor,
            GRU,
            Gather,
            GatherElements,
            GatherND,
            /// <summary>
            /// @see [ReLU Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Gemm)
            /// </summary>
            Gemm,
            /// <summary>
            /// @see [GlobalAveragePool Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#GlobalAveragePool)
            /// </summary>
            GlobalAveragePool,
            GlobalLpPool,
            /// <summary>
            /// @see [GlobalMaxPool Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#GlobalMaxPool)
            /// </summary>
            GlobalMaxPool,
            Greater,
            HardSigmoid,
            Hardmax,
            Identity,
            If,
            InstanceNormalization,
            IsInf,
            IsNan,
            LRN,
            LSTM,
            /// <summary>
            /// @see [LeakyReLU Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#LeakyRelu)
            /// </summary>
            LeakyRelu,
            Less,
            Log,
            LogSoftmax,
            Loop,
            LpNormalization,
            LpPool,
            MatMul,
            MatMulInteger,
            Max,
            /// <summary>
            /// @see [MaxPool Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#MaxPool)
            /// </summary>
            MaxPool,
            MaxRoiPool,
            MaxUnpool,
            Mean,
            Min,
            Mod,
            Mul,
            Multinomial,
            Neg,
            NonMaxSuppression,
            NonZero,
            Not,
            OneHot,
            Or,
            /// <summary>
            /// @see [LeakyReLU Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#PRelu)
            /// </summary>
            PRelu,
            Pad,
            Pow,
            QLinearConv,
            QLinearMatMul,
            QuantizeLinear,
            RNN,
            RandomNormal,
            RandomNormalLike,
            RandomUniform,
            RandomUniformLike,
            Reciprocal,
            ReduceL1,
            ReduceL2,
            ReduceLogSum,
            ReduceLogSumExp,
            ReduceMax,
            ReduceMean,
            ReduceMin,
            ReduceProd,
            ReduceSum,
            ReduceSumSquare,
            /// <summary>
            /// @see [ReLU Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Relu)
            /// </summary>
            Relu,
            Reshape,
            ReverseSequence,
            RoiAlign,
            Round,
            Scan,
            Scatter,
            ScatterElements,
            ScatterND,
            Selu,
            SequenceAt,
            SequenceConstruct,
            SequenceEmpty,
            SequenceErase,
            SequenceInsert,
            SequenceLength,
            Shape,
            Shrink,
            Sigmoid,
            Sign,
            Sin,
            Sinh,
            Size,
            Slice,
            /// <summary>
            /// @see [Conv Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Softmax)
            /// </summary>
            Softmax,
            Softplus,
            Softsign,
            SpaceToDepth,
            Split,
            SplitToSequence,
            Sqrt,
            Squeeze,
            StringNormalizer,
            Sub,
            Sum,
            Tan,
            Tanh,
            TfldfVectorizer,
            ThresholdRelu,
            Tile,
            TopK,
            Transpose,
            Unique,
            Unsqueeze,
            Upsample,
            Where,
            Xor
        }
#pragma warning restore 1591

        /// <summary>
        /// The constructor.
        /// </summary>
        public OnnxDefinitions()
        {

        }

        /// <summary>
        /// Returns the version of a given operator, or -1 if the version information has yet to be added.
        /// </summary>
        /// <param name="op">Specifies the operator who's version to retrieve.</param>
        /// <returns>The ONNX operator set version is returned for the operator specified.</returns>
        public int GetVersion(OPERATORS op)
        {
            if (!m_rgOperatorVersions.ContainsKey(op))
                return -1;

            m_rgOperatorVersions.Add(OPERATORS.AveragePool, 11);
            m_rgOperatorVersions.Add(OPERATORS.Conv, 10);
            m_rgOperatorVersions.Add(OPERATORS.Gemm, 11);
            m_rgOperatorVersions.Add(OPERATORS.GlobalAveragePool, 1);
            m_rgOperatorVersions.Add(OPERATORS.GlobalMaxPool, 9);
            m_rgOperatorVersions.Add(OPERATORS.LeakyRelu, 9);
            m_rgOperatorVersions.Add(OPERATORS.MaxPool, 12);
            m_rgOperatorVersions.Add(OPERATORS.PRelu, 9);
            m_rgOperatorVersions.Add(OPERATORS.Relu, 5);
            m_rgOperatorVersions.Add(OPERATORS.Softmax, 11);

            return m_rgOperatorVersions[op];
        }
    }
}
