﻿using UncomplicatedCustomRoles.API.Struct;
using UnityEngine;

namespace UncomplicatedCustomRoles.Extensions
{
    public static class Vector3Extension
    {
        /// <summary>
        /// Add a X value to the current <see cref="Vector3"/>
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="value"></param>
        /// <returns>The modificed <see cref="Vector3"/></returns>
        public static Vector3 AddX(this Vector3 vector, float value)
        {
            vector.x += value; 
            return vector;
        }

        /// <summary>
        /// Add a Y value to the current <see cref="Vector3"/>
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="value"></param>
        /// <returns>The modificed <see cref="Vector3"/></returns>
        public static Vector3 AddY(this Vector3 vector, float value)
        {
            vector.y += value;
            return vector;
        }

        /// <summary>
        /// Add a Z value to the current <see cref="Vector3"/>
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="value"></param>
        /// <returns>The modificed <see cref="Vector3"/></returns>
        public static Vector3 AddZ(this Vector3 vector, float value)
        {
            vector.z += value;
            return vector;
        }

        /// <summary>
        /// Convert the current <see cref="Vector3"/> to a local <see cref="Triplet{TFirst, TSecond, TThird}}"/>
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static Triplet<float, float, float> ToTriplet(this Vector3 vector)
        {
            return new(vector.x, vector.y, vector.z);
        }
    }
}
