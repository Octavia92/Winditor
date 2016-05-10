﻿using OpenTK;

namespace WindEditor
{
    public class TVector2PropertyValue : TBasePropertyValue<Vector2>
    {
        public override Vector2 Value
        {
            get { return m_value; }

            set
            {
                var oldValue = m_value;
                EditPropertyValueAction undoRedoEntry = new EditPropertyValueAction(
                    () => m_value = oldValue,
                    () => m_value = value,
                    () => OnPropertyChanged("Value"));
                m_undoStack.Push(undoRedoEntry);
            }
        }

        private readonly WUndoStack m_undoStack;
        private Vector2 m_value;

        public TVector2PropertyValue(Vector2 defaultValue, WUndoStack undoStack)
        {
            m_value = defaultValue;
            m_undoStack = undoStack;
        }
    }
}