namespace Factory_Method
{
    class PDFDocumentCreator : TextDocumentCreator
    {
        public override TextDocument Create()
        {
            return new PDFDocument();
        }
    }
}