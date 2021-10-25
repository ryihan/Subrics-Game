#ifndef BOOST_DETAIL_SP_TYPEINFO_HPP_INCLUDED
#define BOOST_DETAIL_SP_TYPEINFO_HPP_INCLUDED

// MS compatible compilers support #pragma once

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
# pragma once
#endif

//  detail/sp_typeinfo.hpp
//
//  Copyright 2007 Peter Dimov
//
// Distributed under the Boost Software License, Version 1.0.
// See accompanying file LICENSE_1_0.txt or copy at
// http://www.boost.org/LICENSE_1_0.txt)

#include <boost/config.hpp>

#if defined( BOOST_NO_TYPEID )

#include <boost/current_function.hpp>
#include <functional>

namespace boost
{

namespace detail
{

class sp_typeinfo
{
private:

    sp_typeinfo( sp_typeinfo const& );
    sp_typeinfo& operator=( sp_typeinfo const& );

    char const * name_;

public:

    explicit sp_typeinfo( char const * name ): name_( name )
    {
    }

    bool operator==( sp_typeinfo const& rhs ) const
    {
        return this == &rhs;
    }

    bool operator!=( sp_typeinfo const& rhs ) const
    {
        return this != &rhs;
    }
