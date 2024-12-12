  Private Shared ReadOnly KnownMagicNumbers As Dictionary(Of UInteger, String) = New Dictionary(Of UInteger, String) From {
      {&H4F153D1D, "PUP File"},   ' PS4 PUP Magic Number
      {&H32424C53, "SLB2 File"},  ' SLB2 Magic Number ("SLB2" in ASCII)
      {&H53454C46, "SELF File"},  ' Hypothetical SELF Magic Number (for demonstration)
      {&H454C4600, "ELF File"}    ' Hypothetical ELF Magic Number (for demonstration)
  }
