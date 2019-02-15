Option Strict On
'********************************************************************
'Name:          Brad Oake                                           *
'Program:       PieceworkPay.vb                                     *
'Date:          February 4th, 2015                                  *
'                                                                   *
'Description:   This is a business tier class for defining and      *
'               calculating piecework pay. Class properties         *
'               include the worker name, and the number of          *
'               pieces. Shared data is also tracked and             *
'               incremented every time the class method -           *
'               calculatePay() is called. Validation is not in      *
'               the business tier of the logic as required by       *
'               the documentation provided.                         *
'********************************************************************
Imports Microsoft.VisualBasic

Friend Class PieceworkPay

#Region "CLASS PROPERTIES"
    Private workerName As String                        'holds the worker name.
    Private numberOfPieces As Integer                   'holds the number of pieces the worker produced.

    Private workerPay As Double

    Private Shared employeesProcessed As Integer        'holds the total number of employees that have been processed.
    Private Shared totalPay As Double = 0               'holds the total pay of all employees processed.
    Private Shared averagePay As Double                 'holds the calculated average pay of all employees processed.
    Private Shared totalPiecesAssembled As Integer = 0  'holds the total pieces assembled by all employees processed.
#End Region

#Region "CONSTRUCTORS"
    'parameterized constructor for instantiation
    Friend Sub New(ByVal workerName As String, ByVal numberOfPieces As Integer)
        Me.workerName = workerName
        Me.numberOfPieces = numberOfPieces
        calculatePay()
    End Sub

    'default constructor for instantiation
    Friend Sub New()

    End Sub
#End Region

#Region "PROPERTY PROCEDURES"
    Friend ReadOnly Property WorkerPayment() As Double
        Get
            Return WorkerPay
        End Get
    End Property

    'Read/write properties
    Friend Property WorkerIdentifier() As String
        Get
            Return WorkerName
        End Get
        Set(ByVal setWorkerName As String)
            workerName = setWorkerName
        End Set
    End Property

    Friend Property NumberOfParts() As Integer
        Get
            Return NumberOfPieces
        End Get
        Set(setNumberOfPieces As Integer)
            numberOfPieces = setNumberOfPieces
        End Set
    End Property

    'The shared properties can only be read. Data cannot be written to them directly.
    Friend Shared ReadOnly Property EmployeesScanned() As Integer
        Get
            Return EmployeesProcessed
        End Get
    End Property

    Friend Shared ReadOnly Property OverallPay() As Double
        Get
            Return TotalPay
        End Get
    End Property

    Friend Shared ReadOnly Property MeanPay() As Double
        Get
            Return AveragePay
        End Get
    End Property

    Friend Shared ReadOnly Property TotalPiecesManufactured() As Integer
        Get
            Return TotalPiecesAssembled
        End Get
    End Property
#End Region

#Region "CLASS METHODS"
    'This method calculates the pay for an individual employee and then recalculates the summary data
    Friend Sub CalculatePay()
        'Constants which define the thresholds that increase the pay for each piece produced.
        Const TIER_ONE_MAX_PIECES As Integer = 199
        Const TIER_TWO_MAX_PIECES As Integer = 399
        Const TIER_THREE_MAX_PIECES As Integer = 599

        'Constants which define the pay for each piece based on the threshold constants above.
        Const TIER_ONE_PAY_PER_PIECE As Double = 0.5
        Const TIER_TWO_PAY_PER_PIECE As Double = 0.55
        Const TIER_THREE_PAY_PER_PIECE As Double = 0.6
        Const TIER_FOUR_PAY_PER_PIECE As Double = 0.65

        'This IfElse chain finds the suitable payment based on the number of pieces
        'the worker produced, and then stores the calculated pay.
        If numberOfPieces <= TIER_ONE_MAX_PIECES Then
            workerPay = numberOfPieces * TIER_ONE_PAY_PER_PIECE
        ElseIf numberOfPieces <= TIER_TWO_MAX_PIECES Then
            workerPay = numberOfPieces * TIER_TWO_PAY_PER_PIECE
        ElseIf numberOfPieces <= TIER_THREE_MAX_PIECES Then
            workerPay = numberOfPieces * TIER_THREE_PAY_PER_PIECE
        Else
            workerPay = numberOfPieces * TIER_FOUR_PAY_PER_PIECE
        End If

        'Increment the summary data
        totalPay += workerPay
        totalPiecesAssembled += numberOfPieces
        employeesProcessed += 1

        'Recalculate the average pay
        averagePay = totalPay / employeesProcessed
    End Sub
#End Region

End Class
