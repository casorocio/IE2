Imports System.ComponentModel
Public Class TurnosCollection
    Inherits BindingList(Of TurnosClass)

    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New TurnosClass()
    End Sub

End Class
