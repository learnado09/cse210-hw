namespace Scripture_Challenge
{
    class Word
    {
        public string Text { get; private set; }
        private bool isHidden;

        public Word(string text)
        {
            Text = text;
            isHidden = false;
        }

        public void Hide()
        {
            isHidden = true;
        }

        public void Show()
        {
            isHidden = false;
        }

        public bool IsHidden()
        {
            return isHidden;
        }

        public string GetDisplayText()
        {
            return isHidden ? "[...]" : Text;
        }
    }
}

