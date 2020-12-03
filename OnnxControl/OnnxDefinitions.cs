using System;
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
        Dictionary<OPERATORS, Tuple<int, string>> m_rgOperatorVersions = new Dictionary<OPERATORS, Tuple<int, string>>();

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
            /// <summary>
            /// @see [Abs Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Abs)
            /// </summary>
            Abs,
            /// <summary>
            /// @see [Acos Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Acos)
            /// </summary>
            Acos,
            /// <summary>
            /// @see [Acosh Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Acosh)
            /// </summary>
            Acosh,
            /// <summary>
            /// @see [Add Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Add)
            /// </summary>
            Add,
            And,
            /// <summary>
            /// @see [ArgMax Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ArgMax)
            /// </summary>
            ArgMax,
            /// <summary>
            /// @see [ArgMin Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ArgMin)
            /// </summary>
            ArgMin,
            /// <summary>
            /// @see [Asin Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Asin)
            /// </summary>
            Asin,
            /// <summary>
            /// @see [Asinh Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Asinh)
            /// </summary>
            Asinh,
            /// <summary>
            /// @see [Atan Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Atan)
            /// </summary>
            Atan,
            /// <summary>
            /// @see [Atanh Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Atanh)
            /// </summary>
            Atanh,
            /// <summary>
            /// @see [AveragePool Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#AveragePool)
            /// </summary>
            AveragePool,
            /// <summary>
            /// @see [BatchNormalization Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#BatchNormalization)
            /// </summary>
            BatchNormalization,
            BitShift,
            Cast,
            /// <summary>
            /// @see [Ceil Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Ceil)
            /// </summary>
            Ceil,
            /// <summary>
            /// @see [Clip Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Clip)
            /// </summary>
            Clip,
            Compress,
            /// <summary>
            /// @see [Concat Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Concat)
            /// </summary>
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
            /// <summary>
            /// @see [Cos Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Cos)
            /// </summary>
            Cos,
            /// <summary>
            /// @see [Cosh Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Cosh)
            /// </summary>
            Cosh,
            CumSum,
            DepthToSpace,
            DequantizeLinear,
            Det,
            Div,
            /// <summary>
            /// @see [Dropout Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Dropout)
            /// </summary>
            Dropout,
            Einsum,
            /// <summary>
            /// @see [Elu Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Elu)
            /// </summary>
            Elu,
            Equal,
            Erf,
            /// <summary>
            /// @see [Exp Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Exp)
            /// </summary>
            Exp,
            Expand,
            EyeLike,
            /// <summary>
            /// @see [Flatten Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Flatten)
            /// </summary>
            Flatten,
            /// <summary>
            /// @see [Floor Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Floor)
            /// </summary>
            Floor,
            GRU,
            /// <summary>
            /// @see [Gather Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Gather)
            /// </summary>
            Gather,
            GatherElements,
            GatherND,
            /// <summary>
            /// @see [Gemm Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Gemm)
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
            /// <summary>
            /// @see [LRN Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#LRN)
            /// </summary>
            LRN,
            /// <summary>
            /// @see [LSTM Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#LSTM)
            /// </summary>
            LSTM,
            /// <summary>
            /// @see [LeakyReLU Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#LeakyRelu)
            /// </summary>
            LeakyRelu,
            Less,
            /// <summary>
            /// @see [Log Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Log)
            /// </summary>
            Log,
            LogSoftmax,
            Loop,
            LpNormalization,
            LpPool,
            MatMul,
            MatMulInteger,
            /// <summary>
            /// @see [Max Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Max)
            /// </summary>
            Max,
            /// <summary>
            /// @see [MaxPool Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#MaxPool)
            /// </summary>
            MaxPool,
            MaxRoiPool,
            MaxUnpool,
            Mean,
            /// <summary>
            /// @see [Min Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Min)
            /// </summary>
            Min,
            Mod,
            /// <summary>
            /// @see [Mul Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Mul)
            /// </summary>
            Mul,
            Multinomial,
            /// <summary>
            /// @see [Neg Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Meg)
            /// </summary>
            Neg,
            NonMaxSuppression,
            NonZero,
            Not,
            /// <summary>
            /// @see [OneHot Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#OneHot)
            /// </summary>
            OneHot,
            Or,
            /// <summary>
            /// @see [PRelu Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#PRelu)
            /// </summary>
            PRelu,
            Pad,
            /// <summary>
            /// @see [Pow Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Pow)
            /// </summary>
            Pow,
            QLinearConv,
            QLinearMatMul,
            QuantizeLinear,
            /// <summary>
            /// @see [RNN Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#RNN)
            /// </summary>
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
            /// <summary>
            /// @see [ReduceMax Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ReduceMax)
            /// </summary>
            ReduceMax,
            ReduceMean,
            /// <summary>
            /// @see [ReduceMin Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ReduceMin)
            /// </summary>
            ReduceMin,
            /// <summary>
            /// @see [ReduceProd Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ReduceProd)
            /// </summary>
            ReduceProd,
            /// <summary>
            /// @see [ReduceSum Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ReduceSum)
            /// </summary>
            ReduceSum,
            /// <summary>
            /// @see [ReduceSumSquare Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#ReduceSumSquare)
            /// </summary>
            ReduceSumSquare,
            /// <summary>
            /// @see [Relu Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Relu)
            /// </summary>
            Relu,
            /// <summary>
            /// @see [Reshape Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Reshape)
            /// </summary>
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
            /// <summary>
            /// @see [Sigmoid Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Sigmoid)
            /// </summary>
            Sigmoid,
            /// <summary>
            /// @see [Sign Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Sign)
            /// </summary>
            Sign,
            /// <summary>
            /// @see [Sin Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Sin)
            /// </summary>
            Sin,
            /// <summary>
            /// @see [Sinh Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Sinh)
            /// </summary>
            Sinh,
            Size,
            /// <summary>
            /// @see [Slice Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Slice)
            /// </summary>
            Slice,
            /// <summary>
            /// @see [Softmax Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Softmax)
            /// </summary>
            Softmax,
            Softplus,
            Softsign,
            SpaceToDepth,
            /// <summary>
            /// @see [Split Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Split)
            /// </summary>
            Split,
            SplitToSequence,
            Sqrt,
            /// <summary>
            /// @see [Squeeze Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Squeeze)
            /// </summary>
            Squeeze,
            StringNormalizer,
            /// <summary>
            /// @see [Sub Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Sub)
            /// </summary>
            Sub,
            /// <summary>
            /// @see [Sum Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Sum)
            /// </summary>
            Sum,
            Tan,
            /// <summary>
            /// @see [Tanh Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Tanh)
            /// </summary>
            Tanh,
            TfldfVectorizer,
            ThresholdRelu,
            /// <summary>
            /// @see [Tile Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Tile)
            /// </summary>
            Tile,
            TopK,
            /// <summary>
            /// @see [Transpose Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Transpose)
            /// </summary>
            Transpose,
            Unique,
            /// <summary>
            /// @see [Unsqueeze Operator](https://github.com/onnx/onnx/blob/master/docs/Operators.md#Unsqueeze)
            /// </summary>
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
            addOperator(OPERATORS.Abs, 13);
            addOperator(OPERATORS.Acos, 7);
            addOperator(OPERATORS.Acosh, 9);
            addOperator(OPERATORS.Add, 7);
            addOperator(OPERATORS.ArgMax, 13);
            addOperator(OPERATORS.ArgMin, 13);
            addOperator(OPERATORS.Asin, 7);
            addOperator(OPERATORS.Asinh, 9);
            addOperator(OPERATORS.Atan, 7);
            addOperator(OPERATORS.Atanh, 9);
            addOperator(OPERATORS.AveragePool, 11);
            addOperator(OPERATORS.BatchNormalization, 9);
            addOperator(OPERATORS.Ceil, 13);
            addOperator(OPERATORS.Clip, 13);
            addOperator(OPERATORS.Concat, 11); 
            addOperator(OPERATORS.Conv, 10);
            addOperator(OPERATORS.Cos, 7);
            addOperator(OPERATORS.Cosh, 9);
            addOperator(OPERATORS.Dropout, 12);
            addOperator(OPERATORS.Elu, 6);
            addOperator(OPERATORS.Exp, 13);
            addOperator(OPERATORS.Flatten, 11);
            addOperator(OPERATORS.Floor, 13);
            addOperator(OPERATORS.Gather, 13);
            addOperator(OPERATORS.Gemm, 11);
            addOperator(OPERATORS.GlobalAveragePool, 1);
            addOperator(OPERATORS.GlobalMaxPool, 9);
            addOperator(OPERATORS.LeakyRelu, 9);
            addOperator(OPERATORS.LRN, 1);
            addOperator(OPERATORS.LSTM, 7);
            addOperator(OPERATORS.Log, 13);
            addOperator(OPERATORS.Max, 13);
            addOperator(OPERATORS.Min, 13);
            addOperator(OPERATORS.MaxPool, 12);
            addOperator(OPERATORS.Mul, 7);
            addOperator(OPERATORS.Neg, 13);
            addOperator(OPERATORS.OneHot, 11);
            addOperator(OPERATORS.Pow, 13);
            addOperator(OPERATORS.PRelu, 9);
            addOperator(OPERATORS.Relu, 5);
            addOperator(OPERATORS.Reshape, 5);
            addOperator(OPERATORS.RNN, 7);
            addOperator(OPERATORS.ReduceMax, 13);
            addOperator(OPERATORS.ReduceMin, 13);
            addOperator(OPERATORS.ReduceProd, 13);
            addOperator(OPERATORS.ReduceSum, 13);
            addOperator(OPERATORS.ReduceSumSquare, 13);
            addOperator(OPERATORS.Sigmoid, 13);
            addOperator(OPERATORS.Sin, 7);
            addOperator(OPERATORS.Sinh, 9);
            addOperator(OPERATORS.Sign, 9);
            addOperator(OPERATORS.Slice, 13);
            addOperator(OPERATORS.Softmax, 11);
            addOperator(OPERATORS.Split, 11);
            addOperator(OPERATORS.Squeeze, 13);
            addOperator(OPERATORS.Sub, 13);
            addOperator(OPERATORS.Sum, 13);
            addOperator(OPERATORS.Tan, 7);
            addOperator(OPERATORS.Tanh, 13);
            addOperator(OPERATORS.Tile, 13);
            addOperator(OPERATORS.Transpose, 13);
            addOperator(OPERATORS.Unsqueeze, 13);
        }

        private void addOperator(OPERATORS op, int nVer)
        {
            m_rgOperatorVersions.Add(op, new Tuple<int, string>(nVer, op.ToString()));
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

            return m_rgOperatorVersions[op].Item1;
        }

        /// <summary>
        /// Returns the string representation of the operator.
        /// </summary>
        /// <param name="op">Specifies the operator who's string to retrieve.</param>
        /// <returns>The string representation of the operator used by ONNX is returned.</returns>
        public string GetString(OPERATORS op)
        {
            if (!m_rgOperatorVersions.ContainsKey(op))
                return op.ToString();

            return m_rgOperatorVersions[op].Item2;
        }
    }
}
