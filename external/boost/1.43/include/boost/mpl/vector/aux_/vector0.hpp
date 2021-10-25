#ifndef BOOST_MPL_VECTOR_AUX_VECTOR0_HPP_INCLUDED
#define BOOST_MPL_VECTOR_AUX_VECTOR0_HPP_INCLUDED
#include <boost/mpl/long.hpp>
#include <boost/mpl/void.hpp>
#include <boost/mpl/aux_/na.hpp>
#include <boost/mpl/aux_/type_wrapper.hpp>

#include <boost/mpl/vector/aux_/iterator.hpp>
#include <boost/mpl/vector/aux_/tag.hpp>
#include <boost/mpl/aux_/config/typeof.hpp>

namespace boost { namespace mpl {

template< typename Dummy = na > struct vector0;

template<> struct vector0<na>
{
#if defined(BOOST_MPL_CFG_TYPEOF_BASED_SEQUENCES)
    typedef aux::vector_tag tag;
    typedef vector0         type;
    typedef long_<32768>    lower_bound_;
    typedef lower_bound_    upper_bound_;
    typedef long_<0>        size;

    static aux::type_wrapper<void_> item_(...);
#else
    typedef aux::vector_tag<0> tag;
    typedef vector0 type;
