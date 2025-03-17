using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablesExamples
{
	public class Wookiee
	{
		public string? Name { get; set; }
		public int? Height { get; set; }
		public int? Weight { get; set; }


		public string? GetState(string? name)
		{
			return null;
		}

		[DisallowNull]
		public string? ReviewComment
		{
			get => this._comment;
			set => this._comment = value ?? throw new ArgumentNullException(nameof(value), "Cannot set to null");
		}
		string? _comment;

		[return: MaybeNull]
		public T Find<T>(IEnumerable<T> sequence, Func<T, bool> predicate)
		{
			return sequence.FirstOrDefault(predicate);
		}

		[return: MaybeNull]
		public string GetIfExists([DisallowNull] string key)
		{
			new Dictionary<string, string>().TryGetValue(key, out string? value); // Warning  CS8600  Converting null literal or possible null value to non-nullable type.
			return value; // Warning  CS8603  Possible null reference return.
		}

		public bool IsNullOrEmpty([NotNullWhen(false)] string? value)
		{
			return string.IsNullOrEmpty(value);
		}

		public static bool IsValidInput([NotNullWhen(true)] string? input)
		{
			return !string.IsNullOrWhiteSpace(input);
		}

		[return: NotNullIfNotNull(nameof(input))]
		public static string? ChangeCase(string? input)
		{
			return input?.ToLower();
		}


		public static void AllowNull([AllowNull] string name)
		{
			if (name == null)
			{

			}
		}

	}
}
